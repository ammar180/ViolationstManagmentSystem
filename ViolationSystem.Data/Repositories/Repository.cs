using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using ViolationSystem.Data.EF;
using ViolationSystem.Data.Entities;

namespace ViolationSystem.Data.Repositories
{
	public class Repository : IRepository
	{
		private readonly Model db = new Model();
		private static Repository instance;
		public async Task<bool> EditViolation(Violation violationModel)
		{
			try
			{
				var existingViolation = await db.Violations.FindAsync(violationModel.Id);
				if (existingViolation != null)
				{
					db.Entry(existingViolation).State = EntityState.Detached;
				}

				db.Violations.AddOrUpdate(violationModel);
				await db.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				// Log exception
				return false;
				throw new InvalidOperationException("An error occurred while editing the violation.", ex);
			}
		}

		public async Task AddViolation(Violation violationModel)
		{
			try
			{
				db.Violations.Add(violationModel);
				await db.SaveChangesAsync();
			}
			catch
			{
				try
				{
					db.Entry(violationModel.Truck).State = EntityState.Detached;
					db.Violations.Add(violationModel);
					await db.SaveChangesAsync();
				}
				catch {
					throw new Exception("Invalid Opration!");
				}
			}
		}

		public async Task<ICollection<Violation>> GetAllViolations()
		{
			return await db.Violations.ToListAsync();
		}
		public async Task<ICollection<Violation>> GetViolationsByCode(string digits, string chars)
		{
			try
			{
				var truck = db.Trucks
					.Where(x => 
					x.TruckCode.Substring(3).Contains(digits)
					&& x.TruckCode.Substring(0,3).Contains(chars)
					);
				if (truck.Any())
				{
					var violations = truck
						.SelectMany(x => x.Violations)
						.Include(x => x.Truck)
						.Take(500)
						.ToList();
					return violations;
				}
				else
					throw new InvalidOperationException();
			}
			catch(Exception)
			{
				return new List<Violation>();
			}
		}

		public async Task<ICollection<Violation>> GetViolationsInDateRange(DateTime StartDate, DateTime EndDate)
		{
			return await db.Violations.Where(x =>
					x.ViolationDate >= StartDate
					&& x.ViolationDate <= EndDate
					).OrderBy(x => x.ViolationDate
					).ToListAsync();
		}
		public async Task<ICollection<Violation>> GetViolationsInMonth(int month)
		{
			return await db.Violations.Where(x =>
					x.ViolationDate.Month == month &&
					x.ViolationDate.Year == DateTime.Now.Year
					).OrderBy(x => x.ViolationDate
					).ToListAsync();
		}
		
		public static Repository GetInstance()
		{
			if (instance == null)
				instance = new Repository();
			return instance;
		}

		public async Task<bool> ValidateIsAdmin(string text1, string text2)
		{
			return await db.Users.AnyAsync(x => x.UserName == text1 && x.Password == text2);
		}

		public async Task<bool> UpdateAdminNamePassword(string OlduserName, string Oldpassword, string NewUserName, string NewPassword)
		{
			var user = await db.Users.FirstOrDefaultAsync(x => x.UserName == OlduserName && x.Password == Oldpassword);
			if (user != null)
			{
				db.Users.AddOrUpdate(new User
				{
					Id = user.Id, 
					UserName = NewUserName,
					Password = NewPassword
				});
				await db.SaveChangesAsync();
				return true;
			}
			
			return false; 
		}

		public async Task AddTrucksRange(List<Truck> trucks)
		{
            foreach (var item in trucks)
            {
				try
				{
					db.Trucks.Add(item);
					await db.SaveChangesAsync();
				}
				catch (DbUpdateException)
				{ }
            }
			
		}
		public async Task AddViolationRange(List<Violation> violations)
		{
            foreach (var violationModel in violations)
				await AddViolation(violationModel);
		}

		public async Task UpdateViolations(List<Violation> violationsList)
		{
			try
			{
				foreach (var updatedViolation in violationsList)
				{
					// Load the existing violation with the current TruckCode
					//var existingViolation = await db.Violations
					//								.Include(v => v.Truck)
					//								.FirstOrDefaultAsync(v => v.Id == updatedViolation.Id);
					var t = db.Trucks.FirstOrDefault(x => x.TruckCode == updatedViolation.TruckCode);
					updatedViolation.Truck = t;
					if(t == null)
					{
						t = new Truck() { TruckCode = updatedViolation.TruckCode , IsExplored = false};
						db.Entry(t).State = EntityState.Added;
						updatedViolation.Truck = t;
					}
					
					db.SaveChanges();
				}
			
				//await RemoveViolations(violationsList);
			}
			catch (Exception ex)
			{
			}
		}

		public async Task RemoveViolations(List<Violation> deletedViolations)
		{
			try
			{
				foreach (var item in deletedViolations)
				{
					db.Violations.Remove(item);
					await db.SaveChangesAsync();
				}
			}catch { }
		}

		public async Task AddTruckViolations(List<Violation> list)
		{
			if (list == null || list.Count == 0)
			{
				throw new ArgumentException("List of violations is empty or null.");
			}

			string code = list.FirstOrDefault()?.TruckCode;
			if (code == null)
			{
				throw new ArgumentException("List of violations does not contain a valid TruckCode.");
			}

			var truck = await db.Trucks.Include(t => t.Violations).FirstOrDefaultAsync(x => x.TruckCode == code);

			if (truck == null)
			{
				// If the truck does not exist, create a new one and add it to the context
				truck = new Truck()
				{
					TruckCode = code,
					IsExplored = false,
					Violations = new List<Violation>()
				};
				db.Trucks.Add(truck);
			}

			// Iterate through each violation
			foreach (var violation in list)
			{
				// Check if the violation already exists in the truck's violations collection
				
				violation.TruckCode = truck.TruckCode; // Ensure the violation has the correct TruckCode
				violation.Truck = truck; // Associate the violation with the truck
				db.Violations.Add(violation); // Add the violation to the context
				
			}

			await db.SaveChangesAsync();
		}

		public async Task<List<Truck>> GetTrafficTrucks(int trucksCount, string targetUnit, DateTime startDate)
		{
			return await db.Trucks.Include(t => t.Violations).Where(x => 
				!(x.IsExplored??false)
				&& x.Violations.Any(v => 
						v.Unit == targetUnit 
						&& v.ViolationDate >= startDate)
			).Take(trucksCount)
			.ToListAsync();
		}
	}
}
