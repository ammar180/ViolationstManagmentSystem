using System.Data.Entity;
using ViolationsCollector.Model.Entities;

namespace ViolationsCollector.Model
{
	public partial class ViolationsEntities : DbContext
	{
		public ViolationsEntities()
			: base($"name=ViolationsCollector.Properties.Settings.SQLconnectionFile")
		{
		}

		//public virtual DbSet<Truck> Trucks { get; set; }
		public virtual DbSet<Violation> Violations { get; set; }
	}
}
