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

		public async Task<bool> AddViolation(Violation violationModel)
		{
			try
			{
				db.Violations.Add(violationModel);
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

		public async Task<ICollection<Violation>> GetAllViolations()
		{
			return await db.Violations.ToListAsync();
		}
		public async Task<ICollection<Violation>> GetViolationsByCode(string digits, string chars)
		{
			try
			{
				var truck = db.Trucks.Where(x => 
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

		//public async Task<bool> CheckTruckExest(Truck Code)
		//{
		//	return await db.Trucks.AnyAsync(x => x == Code);
		//}

		//public async Task<bool> AddTruck(Truck truckModel)
		//{
		//	try
		//	{
		//		db.Trucks.Add(truckModel);
		//		await db.SaveChangesAsync();
		//		return true;
		//	}
		//	catch (Exception ex)
		//	{
		//		// Log exception
		//		return false;
		//		throw new InvalidOperationException("An error occurred while editing the violation.", ex);
		//	}
		//}
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
            foreach (var violation in violations)
            {
				try
				{
					db.Violations.Add(violation);
					await db.SaveChangesAsync();
				}
				catch(DbUpdateException)
				{
					try
					{
						db.Entry(violation.Truck).State = EntityState.Detached;
						db.Violations.Add(violation);
						await db.SaveChangesAsync();
					}
					catch { }
				}
            }
		}

		public async void UpdateViolations(List<Violation> violationsList)
		{
			foreach (var updatedViolation in violationsList)
            {
				try
				{
					// Load the existing violation with the current TruckCode
					var existingViolation = await db.Violations.Include(v => v.Truck)
															   .FirstOrDefaultAsync(v => v.Id == updatedViolation.Id);
					if (existingViolation == null)
					{
						throw new InvalidOperationException("Violation not found.");
					}

					// Check if the new TruckCode exists
					var newTruck = await db.Trucks.FirstOrDefaultAsync(t => t.TruckCode == updatedViolation.TruckCode);
					if (newTruck == null)
					{
						newTruck = new Truck()
						{
							TruckCode = updatedViolation.TruckCode,
							IsExplored = false
						};

						db.Entry(newTruck).State = EntityState.Detached;

						db.Trucks.Add(newTruck);
						await db.SaveChangesAsync();
					}

					// Update the properties
					existingViolation.TruckCode = updatedViolation.TruckCode;
					existingViolation.Truck = newTruck;
					existingViolation.ViolationDate = updatedViolation.ViolationDate;
					existingViolation.Unit = updatedViolation.Unit;
					existingViolation.ElManfaz = updatedViolation.ElManfaz;

					// Update other properties if necessary
					existingViolation.ReportNumber = updatedViolation.ReportNumber;
					existingViolation.PaymentDate = updatedViolation.PaymentDate;
					existingViolation.BlockDate = updatedViolation.BlockDate;

					// Save changes
					await db.SaveChangesAsync();
				}
				catch (Exception ex)
				{
				}
			}
		}

		public void RemoveViolations(List<Violation> deletedViolations)
		{
			foreach (var item in deletedViolations)
			{
				db.Violations.Remove(item);
				db.SaveChanges();
			}
		}
	}
}
