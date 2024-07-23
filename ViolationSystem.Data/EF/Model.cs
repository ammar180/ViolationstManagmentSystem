using System.Data.Entity;
using ViolationSystem.Data.Entities;

namespace ViolationSystem.Data.EF
{
	public class Model : DbContext
	{
		// Your context has been configured to use a 'Model' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'ViolationSystem.Data.EF.Model' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'Model' 
		// connection string in the application configuration file.
		public Model()
			: base("name=SqlConnection")
		{
		}

		public virtual DbSet<Truck> Trucks { get; set; }
		public virtual DbSet<Violation> Violations { get; set; }
		public virtual DbSet<User> Users { get; set; }
	}

}