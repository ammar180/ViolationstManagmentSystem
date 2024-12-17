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
		public Repository(string sqlConnection, bool importBehev = false)
		{
			db = new Model(sqlConnection);
			db.Configuration.AutoDetectChangesEnabled = !importBehev;
			db.Configuration.ValidateOnSaveEnabled = !importBehev;
		}
		public void UpdateViolation(Violation violationModel)
		{
			try
			{
				db.SaveChanges();
			}
			catch (DbUpdateException)
			{
				db.Trucks.Add(new Truck { TruckCode = violationModel.TruckCode, IsExplored = false });
				db.SaveChanges();
			}
		}

		public async Task AddViolation(Violation violationModel)
		{
			try
			{
				db.Violations.Add(violationModel);
				await db.SaveChangesAsync();
			}
			catch (DbUpdateException)
			{
				try
				{
					db.Entry(violationModel.Truck).State = EntityState.Detached;
					db.Violations.Add(violationModel);
					await db.SaveChangesAsync();
				}
				catch (Exception ex)
				{
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
					.Where(x => x.TruckCode.Contains(digits)
							 && x.TruckCode.Contains(chars));
				if (truck.Any())
				{
					var violations = new List<Violation>();
					violations = await truck
						.SelectMany(x => x.Violations)
						.Include(x => x.Truck)
						.OrderBy(v => v.ViolationDate)
						.ToListAsync();
					return violations;
				}
				else
					throw new Exception("لم يتم العثور على سيارة مطابقة");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return new List<Violation>();
			}
		}

		public async Task<bool> ValidateIsAdmin(string txtName, string txtPass) 
			=> await db.Users.AnyAsync(x => x.UserName == txtName && x.Password == txtPass);

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

		public async Task AddTruck(Truck truck)
		{
			try
			{
				db.Trucks.Add(truck);
				await db.SaveChangesAsync();
			}
			catch (DbUpdateException)
			{
			}

		}
		public async Task AddViolationRange(List<Violation> addedViolations)
		{
			if (addedViolations == null || addedViolations.Count == 0)
				return;

			for (int i = 0; i < addedViolations.Count; i++)
				await AddViolation(addedViolations[i]);
		}

		public void UpdateViolations(List<Violation> violationsList)
		{
			if (violationsList.Count == 0 || violationsList == null)
				return;
			try
			{
				for (int i = 0; i < violationsList.Count; i++)
					UpdateViolation(violationsList[i]);
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void RemoveViolations(List<Violation> deletedViolations)
		{
			if (deletedViolations.Count == 0 || deletedViolations == null)
				return;

			for(int i = 0; i < deletedViolations.Count; i++)
				RemoveViolation(deletedViolations[i]);
		}

		private void RemoveViolation(Violation item)
		{
			try
			{
				db.Violations.Remove(item);
				db.SaveChanges();
			}
			catch { }
		}

		public async Task AddTruckViolations(List<Violation> addedViolations)
		{
			if (addedViolations == null || addedViolations.Count == 0)
				return;
            
			string code = addedViolations.FirstOrDefault()?.TruckCode;
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
			foreach (var violation in addedViolations)
			{
				// Check if the violation already exists in the truck's violations collection

				violation.TruckCode = truck.TruckCode; // Ensure the violation has the correct TruckCode
				violation.Truck = truck; // Associate the violation with the truck
				truck.Violations.Add(violation); // Add the violation to the context

			}

			await db.SaveChangesAsync();
		}

		public async Task<List<Truck>> GetTrafficTrucks(int trucksCount, string targetUnit, DateTime? startDate, int minViolationsCount)
		{
			var trucks = await db.Trucks
				.Include(t => t.Violations)
				.Where(x =>
				!x.IsExplored
				&& x.Violations.Count >= minViolationsCount
				&& x.Violations
					.Any(v => v.Unit.Replace("أ", "ا") == targetUnit
						&& (!startDate.HasValue || v.ViolationDate >= startDate))
			).Take(trucksCount)
			.ToListAsync();

			return trucks;
		}

		public async Task<List<Violation>> ViolationReport(List<string> units, DateTime? vdateStart, DateTime? vdateEnd, DateTime? pydateStart, DateTime? pydateEnd)
		{
			return await db.Violations.Where(v =>
				units.Contains(v.Unit.Replace("أ", "ا"))
				&& (!vdateStart.HasValue || (v.ViolationDate >= vdateStart && v.ViolationDate < vdateEnd))
				&& (!pydateStart.HasValue || (v.PaymentDate >= pydateStart && v.PaymentDate < pydateEnd))
			).OrderBy(v => v.ViolationDate)
			.ToListAsync();
		}

		public async void UpdateTrucksToExplored(List<Truck> trucks)
		{
			trucks.ForEach(x => x.IsExplored = true);
			await db.SaveChangesAsync();
		}
	}
}
