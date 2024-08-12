using Microsoft.EntityFrameworkCore;
using ViolationsCollecting.Model.Entities;

namespace ViolationsCollecting.Model.Repositories
{
	public class Repository : IRepository
	{
        public Repository()
        {
			int lastYear = Properties.Settings.Default.CurrentYear;
			// if it year pass
			if(DateTime.Now.Year != lastYear)
			{
				this.RemoveViolationsInLastYear(lastYear);

				Properties.Settings.Default.CurrentYear = DateTime.Now.Year;
				Properties.Settings.Default.Save();
			}
        }
        private readonly ViolationsEntities db = new ViolationsEntities();

		public async Task<bool> EditViolation(Violation violationModel)
		{
			try
			{
				var existingViolation = await db.Violations.FindAsync(violationModel.Id);
				if (existingViolation != null)
				{
					db.Entry(existingViolation).State = EntityState.Detached;
				}

				db.Violations.Update(violationModel);
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
		//public async Task<List<ICollection<Violation>>> GetViolationsForTrucksByCode(string TruckCode)
		//{
		//	try
		//	{
		//		return await db.Trucks.Where(t => t.TruckCode.Contains(TruckCode)).Select(x => x.Violations).ToListAsync();
		//	}
		//	catch
		//	{
		//		return new List<ICollection<Violation>>();
		//	}
		//}

		//public async Task<bool> CheckTruckExest(string Code)
		//{
		//	return await db.Trucks.AnyAsync(x => x.TruckCode == Code);
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
		public bool CanConnect()
		{
			return db.Database.CanConnect();
		}

		public async Task<List<Violation>> GetViolationsInDateRange(DateTime StartDate, DateTime EndDate)
		{
			return await db.Violations.Where(x =>
					x.RegistrationDate >= StartDate
					&& x.RegistrationDate <= EndDate
					).OrderBy(x => x.ViolationDate
					).ToListAsync();
		}
		public async Task<ICollection<Violation>> GetViolationsInMonth(int month)
		{
			return await db.Violations.Where(x =>
					x.ViolationDate.Month == month &&
					x.RegistrationDate.Year == DateTime.Now.Year
					).OrderBy(x => x.ViolationDate
					).ToListAsync();
		}
		public async Task RemoveViolationsInLastYear(int year)
		{
			var violations = db.Violations.Where(x => x.RegistrationDate.Year == year);
			db.Violations.RemoveRange(violations);
			await db.SaveChangesAsync();
		}

		public async Task<bool> CheckViolationInsertedBefore(string Code, DateTime dateTime)
		{
			return await db.Violations.AnyAsync(x => x.ViolationDate == dateTime && x.TruckCode == Code);
		}
	}
}
