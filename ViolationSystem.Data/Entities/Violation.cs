namespace ViolationSystem.Data.Entities
{
    using System;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Violation
    {
        [Key]
        public int Id { get; set; }

		[DisplayName("رقم الشاحنة")]
		public string TruckCode { get; set; }
		[DisplayName("تاريخ المخالفة")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "تاريخ المخالفة مطلوب")]
        public DateTime ViolationDate { get; set; }
		[DisplayName("الوحدة")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "الوحدة المسؤولة لتسجيل المخالفة مطلوبة")]
		public string Unit { get; set; }
		[DisplayName("المنفذ")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "المنفذ مطلوب")]
        public string ElManfaz { get; set; }

        // Transactions
        public string ReportNumber { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? BlockDate { get; set; }
        [ForeignKey("TruckCode")]
        public Truck Truck { get; set; }

    }
}
