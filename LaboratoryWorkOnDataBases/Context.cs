using Microsoft.EntityFrameworkCore;

namespace LaboratoryWorkOnDataBases
{
	internal class Context : DbContext
	{
		public virtual DbSet<ConstructionCompany> ConstructionCompanies { get; set; } = null!;

		public virtual DbSet<ConstructionRepair> ConstructionRepairs { get; set; } = null!;

		public virtual DbSet<Customer> Customers { get; set; } = null!;

		public virtual DbSet<Order> Orders { get; set; } = null!;

		public virtual DbSet<RepairInvoice> RepairInvoices { get; set; } = null!;

		public virtual DbSet<TeamOfWorker> TeamOfWorkers { get; set; } = null!;

		public virtual DbSet<Worker> Workers { get; set; } = null!;

		public Context()
		{
			_ = Database.EnsureDeleted();
			_ = Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			_ = optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LaboratoryWorkOnDataBases;Trusted_Connection=True;");
		}
	}
}