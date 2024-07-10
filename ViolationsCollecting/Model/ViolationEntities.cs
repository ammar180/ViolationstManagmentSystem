namespace ViolationsCollecting.Model
{
	using Microsoft.EntityFrameworkCore;
	using ViolationsCollecting.Model.Entities;

	public partial class ViolationsEntities : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(Properties.Settings.Default.SQLconnection);
			//optionsBuilder.UseSqlite("Data Source=ViolationsCollector.db");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Truck>()
				.HasMany(e => e.Violations)
				.WithOne(e => e.Truck)
				.HasForeignKey(e => e.TruckCode)
				.IsRequired();
		}
		public virtual DbSet<Truck> Trucks { get; set; }
		public virtual DbSet<Violation> Violations { get; set; }
	}
}
