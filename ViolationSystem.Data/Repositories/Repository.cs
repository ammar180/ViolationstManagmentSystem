using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViolationSystem.Data.EF;
using ViolationSystem.Data.Entities;

namespace ViolationSystem.Data.Repositories
{
	public class Repository : IRepository
	{
		private readonly Model db;
        public Repository()
        {
			db = new Model("ViolationstSystem.Properties.Settings.SqlConnectionLocal");
		}
		public Repository(string sqlConnection)
        {
			db = new Model(sqlConnection);
		}
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

		public async Task AddViolation(Violation violationModel, bool canSaveChanges = true)
		{
			try
			{
				db.Violations.Add(violationModel);
				await db.SaveChangesAsync();
			}
			catch(DbUpdateException)
			{
				try
				{
					db.Entry(violationModel.Truck).State = EntityState.Detached;
					db.Violations.Add(violationModel);
					//if(canSaveChanges)
					await db.SaveChangesAsync();
				}
				catch (Exception ex) {
					throw ex;
				}
			}
		}

		public async Task<ICollection<Violation>> GetAllViolations()
		{
			return await db.Violations.ToListAsync();
		}
		public async Task<List<Violation>> GetViolationsByCode(string digits, string chars)
		{
			try
			{
				var truck = db.Trucks
					.Where(x => 
					x.TruckCode.Substring(2).Contains(digits)
					&& x.TruckCode.Substring(0,3).Contains(chars)
					);
				if (truck.Any())
				{
					var violations = new List<Violation>();
					violations = await truck
						.SelectMany(x => x.Violations)
						.Include(x => x.Truck)
						.Take(500)
						.ToListAsync();
					return violations;
				}
				else
					throw new Exception("لم يتم العثور على سيارة مطابقة");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return new List<Violation>();
			}
		}


		public async Task<bool> ValidateIsAdmin(string txtName, string txtPass)
		{
			return await db.Users.AnyAsync(x => x.UserName == txtName && x.Password == txtPass);
		}

		public async Task<bool> UpdateAdminNamePassword(string OlduserName, string Oldpassword, string NewUserName, string NewPassword)
		{
			var user = await db.Users.SingleOrDefaultAsync(x => x.UserName == OlduserName && x.Password == Oldpassword);
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

		public void UpdateViolations(List<Violation> violationsList)
		{
			try
			{
				foreach (var updatedViolation in violationsList)
				{
					try
					{
						db.SaveChanges();
					}
					catch (DbUpdateException)
					{
						db.Trucks.Add(new Truck { TruckCode = updatedViolation.TruckCode, IsExplored = false });
						db.SaveChanges();
					}
				}
			
				//await RemoveViolations(violationsList);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void RemoveViolations(List<Violation> deletedViolations)
		{
			foreach (var item in deletedViolations)
				RemoveViolation(item);
		}

		private void RemoveViolation(Violation item)
		{
			try
			{
				//db.Entry(item).State = EntityState.Deleted;
				//db.Violations.Attach(item);
				db.Violations.Remove(item);
				db.SaveChanges();
			}
			catch { }
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
				truck.Violations.Add(violation); // Add the violation to the context
				
			}

			await db.SaveChangesAsync();
		}

		public async Task<List<Truck>> GetTrafficTrucks(int trucksCount, string targetUnit, DateTime? startDate)
		{
			var trucks = await db.Trucks
				.Include(t => t.Violations)
				.Where(x =>
				!(x.IsExplored)
				&& x.Violations
					.Any(v => v.Unit == targetUnit
						&& !startDate.HasValue || (v.ViolationDate >= startDate))
			).Take(trucksCount)
			.ToListAsync();
			
			trucks.ForEach(x => x.IsExplored = true);
			await db.SaveChangesAsync();
			return trucks;
		}

		public async Task<List<Violation>> ViolationReport(List<string> units, DateTime? vdateStart, DateTime? vdateEnd, DateTime? pydateStart, DateTime? pydateEnd)
		{
			return await db.Violations.Where(v =>
				units.Contains(v.Unit)
				&& (!vdateStart.HasValue || (v.ViolationDate >= vdateStart && v.ViolationDate < vdateEnd))
				&& (!pydateStart.HasValue || (v.PaymentDate >= pydateStart && v.PaymentDate < pydateEnd))
			).OrderBy(v => v.ViolationDate)
			.ToListAsync();
		}
	}
}
