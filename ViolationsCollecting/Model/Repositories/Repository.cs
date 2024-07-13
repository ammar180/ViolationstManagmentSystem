using Microsoft.EntityFrameworkCore;
using ViolationsCollecting.Model.Entities;

namespace ViolationsCollecting.Model.Repositories
{
	public class Repository : IRepository
	{
		private readonly ViolationsEntities db = new ViolationsEntities();

		public async Task<bool> EditViolation(Violation violationModel)
		{
			try
			{
				db.Entry(violationModel).State = EntityState.Modified;
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

		public async Task<ICollection<Violation>> GetViolationsInDateRange(DateTime StartDate, DateTime EndDate)
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
					x.ViolationDate.Month == month
					).OrderBy(x => x.ViolationDate
					).ToListAsync();
		}
		public async Task RemoveViolationsRange(IEnumerable<Violation> violations)
		{
			db.Violations.RemoveRange(violations);
			await db.SaveChangesAsync();
		}

		public async Task<bool> CheckViolationInsertedBefore(string Code)
		{
			return await db.Violations.AnyAsync(x => x.RegistrationDate.Day == DateTime.Now.Day && x.TruckCode == Code);
		}
	}
}
