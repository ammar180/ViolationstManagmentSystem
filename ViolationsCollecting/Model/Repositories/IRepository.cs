using ViolationsCollecting.Model.Entities;

namespace ViolationsCollecting.Model.Repositories
{
	public interface IRepository
	{
		// Search Engin
		Task<List<ICollection<Violation>>> GetViolationsForTrucksByCode(string TruckCode);
		// Oprations:
		Task<ICollection<Violation>> GetViolationsInDateRange(DateTime StartDate, DateTime EndDate);
		Task<ICollection<Violation>> GetAllViolations();
		Task<bool> AddViolation(Violation violationModel);
		Task<bool> AddTruck(Truck truckModel);
		Task<bool> EditViolation(Violation violationModel);
		Task<bool> CheckTruckExest(string Code);
		bool CanConnect();
	}
}
