namespace ViolationsCollector.Model.Entities
{
    using System;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public class Violation
    {
        [Key]
        public int Id { get; set; }

		[DisplayName("رقم الشاحنة")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "رقم السيارة مطلوب 5 او 6 او 7 احرف")]
        [MinLength(6, ErrorMessage ="رقم السيارة مكون من 6 او 7 أحرف فقط")]
        [MaxLength(7)]
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
		[DisplayName("تاريخ التسجيل")]
        public DateTime RegistrationDate { get; set; }

		[DisplayName("الوزن")]
        public string Weight { get; set; }
		[DisplayName("الحمولة")]
        public string Payload { get; set; }

        //public string ReportNumber { get; set; }
        //public DateTime? PaymentDate { get; set; }
        //public DateTime? BlockDate { get; set; }
        
        //[ForeignKey("TruckCode")]
        //public virtual Truck Truck { get; set; }
    }
}
