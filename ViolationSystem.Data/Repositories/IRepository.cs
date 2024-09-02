using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViolationSystem.Data.Entities;

namespace ViolationSystem.Data.Repositories
{
	public interface IRepository
	{
		Task AddViolation(Violation violationModel);
		Task<bool> EditViolation(Violation violationModel);
		Task<ICollection<Violation>> GetAllViolations();
		Task<bool> ValidateIsAdmin(string text1, string text2);
		Task<bool> UpdateAdminNamePassword(string userName, string password, string text1, string text2);
		Task AddViolationRange(List<Violation> violations);
		Task<List<Violation>> GetViolationsByCode(string digits, string chars);
		Task AddTruck(Truck truck);
		void UpdateViolations(List<Violation> violationsList);
		void RemoveViolations(List<Violation> deletedViolations);
		Task AddTruckViolations(List<Violation> list);
		Task<List<Truck>> GetTrafficTrucks(int trucksCount, string targetUnit, DateTime? startDate);
		Task<List<Violation>> ViolationReport(List<string> units, DateTime? vdateStart, DateTime? vdateEnd, DateTime? pydateStart, DateTime? pydateEnd);
	}
}
