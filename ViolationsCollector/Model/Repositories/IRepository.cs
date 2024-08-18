﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViolationsCollector.Model.Entities;

namespace ViolationsCollector.Model.Repositories
{
	public interface IRepository
	{
		// Search Engin
		// Oprations:
		Task<List<Violation>> GetViolationsInDateRange(DateTime StartDate, DateTime EndDate);
		Task<List<Violation>> GetViolationsInMonth(int month);
		Task<bool> AddViolation(Violation violationModel);
		//Task<bool> AddTruck(Truck truckModel);
		Task<bool> EditViolation(Violation violationModel);
		//Task<bool> CheckTruckExest(string Code);
		Task<bool> CheckViolationInsertedBefore(string Code, DateTime dateTime);
		bool CanConnect();
	}
}