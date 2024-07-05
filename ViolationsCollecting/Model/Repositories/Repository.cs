using System;
using System.Collections.Generic;
using System.Linq;
using ViolationsCollecting.Model.Entities;

namespace ViolationsCollecting.Model.Repositories
{
	public class Repository : IRepository
	{
		private readonly ViolationsDB db = new ViolationsDB();
		private static Repository instance;

		public void AddViolation(Violation violationModel, string prevCode = "ع")
		{
			if (violationModel != null)
			{
				// handel in Presenter:-
				if(prevCode != violationModel.Truck.Code) // truck NOT exest
					violationModel.TruckId = TryAddTruckAndGetId(new Truck { Code = violationModel.Truck.Code });
				else
					violationModel.TruckId = GetTruckId(violationModel.Truck.Code);


				db.Violations.Add(violationModel);
				db.SaveChanges();
			}
		}

		public int GetTruckId(string truckCode)
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

		public void DeleteViolation(int id)
		{
			throw new NotImplementedException();
		}

		public void EditViolation(Violation violationModel)
		{
			db.Violations.Add(violationModel);
			db.SaveChanges();
		}

		public ICollection<Violation> GetAllViolations()
		{
			return db.Violations.ToList();
		}

		public List<string> GetNumTrucksByS_E_Date(int TrucksCount, DateTime startDate, DateTime endDate)
		{
			try
			{
				return db.Trucks.Where(x => 
				x.Violations
				.OrderBy(d => d.ViolationDate).First()
				.ViolationDate >= startDate
				&&
				x.Violations
				.OrderBy(d => d.ViolationDate).Last()
				.ViolationDate <= endDate
				).Take(TrucksCount)
				.Select(x => x.Code).ToList();
			}catch 
			{
			    return db.Trucks.Select(x => x.Code).Take(TrucksCount).ToList();
			}
		}
		public ICollection<Violation> GetViolationsForOneTruck(string TruckCode)
		{
			try
			{
				return db.Trucks.First(t => t.Code.Contains(TruckCode)).Violations;
			}catch
			{
				return new List<Violation>();
			}
		}
		public List<ICollection<Violation>> GetViolationsForTrucks(string TruckCode)
		{
			try
			{
				return db.Trucks.Where(t => t.Code.Contains(TruckCode)).Select(x => x.Violations).ToList();
			}catch
			{
				return new List<ICollection<Violation>>();
			}
		}

		public bool IsCanConnect()
		{
			return true;
		}

		public static Repository GetInstance()
		{
			if (instance == null)
				instance = new Repository();
			return instance;
		}
	}
}
