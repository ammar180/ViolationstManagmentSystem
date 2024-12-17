namespace ViolationSystem.Data.Entities
{
    using System;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	[Serializable]
	public class Violation
    {
        [Key]
        public int Id { get; set; }

		[DisplayName("رقم الشاحنة")]
        [Required()]
		[StringLength(128)]
		public string TruckCode { get; set; }
		[DisplayName("تاريخ المخالفة")]
        [Required()]
        public DateTime ViolationDate { get; set; }
		[DisplayName("الوحدة")]
        [Required()]
		[StringLength(64)]
		public string Unit { get; set; }
		[DisplayName("المنفذ")]
		[StringLength(64)]
		public string ElManfaz { get; set; }

        // Transactions
		[DisplayName("رقم البلاغ")]
		[StringLength(128)]
		public string ReportNumber { get; set; }
		[DisplayName("تاريخ الحجز")]
        public DateTime? BlockDate { get; set; }
		[DisplayName("تاريخ السداد")]
        public DateTime? PaymentDate { get; set; }
		[DisplayName("الملاحظات")]
		public string Comments { get; set; }
		[DisplayName("عدد النقلات")]
		public string VCount { get; set; }
        [ForeignKey("TruckCode")]
        public Truck Truck { get; set; }


        public static bool Equals(Violation v1, Violation v2)
		{
			return v1.TruckCode == v2.TruckCode
				&& v1.ViolationDate == v2.ViolationDate
				&& v1.BlockDate == v2.BlockDate
				&& v1.PaymentDate == v2.PaymentDate
				&& v1.ElManfaz == v2.ElManfaz
				&& v1.ReportNumber == v2.ReportNumber
				&& v1.Unit == v2.Unit
				;
		}
	}
}
