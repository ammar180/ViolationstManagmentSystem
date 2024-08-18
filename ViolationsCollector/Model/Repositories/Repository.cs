using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using ViolationsCollector.Model.Entities;

namespace ViolationsCollector.Model.Repositories
{
	public class Repository : IRepository
	{
		private readonly ViolationsEntities db;
		public Repository()
		{
			db = new ViolationsEntities();
			int lastYear = Properties.Settings.Default.CurrentYear;
			// if it year pass
			if (DateTime.Now.Year != lastYear)
			{
				this.RemoveViolationsInLastYear(lastYear);

				Properties.Settings.Default.CurrentYear = DateTime.Now.Year;
				Properties.Settings.Default.Save();
			}
		}

		public async Task<bool> EditViolation(Violation violationModel)
		{
			try
			{
				var existingViolation = db.Violations.Find(violationModel.Id);
				if (existingViolation != null)
				{
					db.Entry(existingViolation).State = System.Data.Entity.EntityState.Detached;
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
			return db.Violations.ToList();
		}
		public bool CanConnect()
		{
			return true;
		}

		public async Task<List<Violation>> GetViolationsInDateRange(DateTime StartDate, DateTime EndDate)
		{
			return await db.Violations.Where(x =>
					x.RegistrationDate >= StartDate
					&& x.RegistrationDate <= EndDate
					).OrderBy(x => x.ViolationDate
					).ToListAsync();
		}
		public async Task<List<Violation>> GetViolationsInMonth(int month)
		{
			return await db.Violations.Where(x =>
					x.ViolationDate.Month == month &&
					x.RegistrationDate.Year == DateTime.Now.Year
					).OrderBy(x => x.ViolationDate
					).ToListAsync();
		}
		public async void RemoveViolationsInLastYear(int year)
		{
			var violations = db.Violations.Where(x => x.RegistrationDate.Year == year);
			db.Violations.RemoveRange(violations);
			await db.SaveChangesAsync();
		}

		public async Task<bool> CheckViolationInsertedBefore(string Code, DateTime dateTime)
		{
			return db.Violations.Any(x => x.ViolationDate == dateTime && x.TruckCode == Code);
		}
	}
}
