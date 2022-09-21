using Microsoft.EntityFrameworkCore;

namespace LaboratoryWorkOnDataBases
{
	internal class Context : DbContext
	{
		public DbSet<ConstructionCompany> ConstructionCompanies { get; set; }

		public DbSet<Order> Orders { get; set; }

		public DbSet<Customer> Customers { get; set; }

		public DbSet<RepairInvoice> RepairInvoices { get; set; }

		public DbSet<ConstructionRepair> ConstructionRepairs { get; set; }

		public DbSet<Worker> Workers { get; set; }

		public DbSet<TeamOfWorkers> TeamOfWorkers { get; set; }



		public Context()
		{
			Database.EnsureDeleted();
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LaboratoryWorkOnDataBases;Trusted_Connection=True;");
		}
	}
}