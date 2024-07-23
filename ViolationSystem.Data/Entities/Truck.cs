namespace ViolationSystem.Data.Entities
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Truck
	{
		public Truck()
		{
			Violations = new HashSet<Violation>();
		}
		[Key]
		public string TruckCode { get; set; }
		public bool? IsExplored { get; set; }

		public virtual ICollection<Violation> Violations { get; set; }

		public bool Equals(Truck other)
		{
			if (other == null) return false;
			return this.TruckCode == other.TruckCode;
		}

		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			if (obj.GetType() != this.GetType()) return false;
			return Equals(obj as Truck);
		}

		public override int GetHashCode()
		{
			return TruckCode?.GetHashCode() ?? 0;
		}
	}
}
