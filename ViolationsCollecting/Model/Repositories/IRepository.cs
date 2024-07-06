using System;
using System.Collections.Generic;
using ViolationsCollecting.Model;

namespace ViolationsCollecting.Model.Repositories
{
	public interface IRepository
	{
		// Search Engin
		List<ICollection<Violation>> GetViolationsForTrucksByCode(string TruckCode);
		// Oprations:
		ICollection<Violation> GetAllViolations();
		void AddViolation(Violation violationModel);
		int TryAddTruckAndGetId(Truck truckModel);
		int GetTruckIdByCode(string truckCode);
		void EditViolation(Violation violationModel);
	}
}
