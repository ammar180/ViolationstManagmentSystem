using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using ViolationsCollecting.Model;

namespace ViolationsCollecting.Model.Repositories
{
	public class Repository : IRepository
	{
		private readonly ViolationEntities db = new ViolationEntities();
		public void AddViolation(Violation violationModel)
		{
			try
			{
				if (violationModel != null)
				{
					db.Violations.Add(violationModel);
					db.SaveChanges();
				}
			}
			catch { }
		}

		public int GetTruckIdByCode(string truckCode)
		{
			return db.Trucks.First(x => x.Code == truckCode).TruckId;
		}

		public int TryAddTruckAndGetId(Truck truckModel)
		{
			// Add Truck to db || Handel in the presenter
			try
			{
				db.Trucks.Add(truckModel);
				db.SaveChanges();
			
				return truckModel.TruckId;
			}
			catch
			{
				// if any error, that mean Truck Exest
				return db.Trucks.First(x => x.Code == truckModel.Code).TruckId;
			}
		}


		public void EditViolation(Violation violationModel)
		{
			try
			{
				db.Violations.AddOrUpdate(violationModel);
				db.SaveChanges();

			}
			catch { }
		}

		public ICollection<Violation> GetAllViolations()
		{
			return db.Violations.ToList();
		}
		public List<ICollection<Violation>> GetViolationsForTrucksByCode(string TruckCode)
		{
			try
			{
				return db.Trucks.Where(t => t.Code.Contains(TruckCode)).Select(x => x.Violations).ToList();
			}
			catch
			{
				return new List<ICollection<Violation>>();
			}
		}
	}
}
