using System;
using System.Collections.Generic;
using ViolationsCollecting.Model.Entities;

namespace ViolationsCollecting.Model.Repositories
{
	public interface IRepository
	{
	    // Search Engin
	    List<string> GetNumTrucksByS_E_Date(int TrucksCount, DateTime startDate, DateTime endDate);

	    ICollection<Violation> GetViolationsForOneTruck(string TruckCode);
		List<ICollection<Violation>> GetViolationsForTrucks(string TruckCode);


		ICollection<Violation> GetAllViolations();

		// Oprations:
		void AddViolation(Violation violationModel, string prevCode = "ع");
		int TryAddTruckAndGetId(Truck truckModel);
		int GetTruckId(string truckCode);
		void EditViolation(Violation violationModel);
		void DeleteViolation(int id);

		bool IsCanConnect();
	}
}
