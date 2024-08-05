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
		//Task AddTrucksRange(List<Truck> trucks);
		Task AddViolationRange(List<Violation> violations);
		Task<ICollection<Violation>> GetViolationsByCode(string digits, string chars);
		Task AddTrucksRange(List<Truck> trucks);
		Task UpdateViolations(List<Violation> violationsList);
		Task RemoveViolations(List<Violation> deletedViolations);
		Task AddTruckViolations(List<Violation> list);
		Task<List<Truck>> GetTrafficTrucks(int trucksCount, string targetUnit, DateTime startDate);
	}
}
