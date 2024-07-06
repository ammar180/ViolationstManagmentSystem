﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViolationsCollecting.Model.Entities
{
    using System;
    using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations.Schema;

	public partial class Violation
	{
		public int Id { get; set; }
		public System.DateTime ViolationDate { get; set; }
		[DisplayName("رقم الشاحنة")]
		[NotMapped]
		public string TruckCode { get => Truck?.Code; set => Truck.Code = value; }
		public string Weight { get; set; }
        public string Payload { get; set; }
        public string ReportNumber { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public int TruckId { get; set; }
        public Nullable<System.DateTime> BlockDate { get; set; }
        public string ResponsibleUnit { get; set; }
        public string elManfath { get; set; }
    
    }
}