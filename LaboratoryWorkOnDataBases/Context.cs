using Microsoft.EntityFrameworkCore;

namespace LaboratoryWorkOnDataBases
{
	internal class Context : DbContext
	{
		public DbSet<ConstructionCompany> ConstructionCompanies { get; set; }

		public DbSet<ConstructionRepair> ConstructionRepairs { get; set; }

		public DbSet<Customer> Customers { get; set; }

		public DbSet<Order> Orders { get; set; }

		public DbSet<RepairInvoice> RepairInvoices { get; set; }

		public DbSet<TeamOfWorker> TeamOfWorkers { get; set; }

		public DbSet<Worker> Workers { get; set; }

		public Context()
		{
			Database.EnsureDeleted();
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LaboratoryWorkOnDataBases;Trusted_Connection=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ConstructionRepair>(entity =>
			{
				entity.HasOne(ConstructionCompany => ConstructionCompany.ConstructionCompany)
				.WithOne(ConstructionRepair => ConstructionRepair.ConstructionRepair)
				.HasForeignKey<ConstructionRepair>(key => key.Id);
			});

			modelBuilder.Entity<Customer>(entity =>
			{
				entity.HasOne(Order => Order.Order)
				.WithOne(Customer => Customer.Customer)
				.HasForeignKey<Customer>(key => key.Id);
			});

			modelBuilder.Entity<Order>(entity =>
			{
				entity.HasOne(ConstructionCompany => ConstructionCompany.ConstructionCompany)
				.WithOne(Order => Order.Order)
				.HasForeignKey<Order>(key => key.Id);
			});

			modelBuilder.Entity<RepairInvoice>(entity =>
			{
				entity.HasOne(Customer => Customer.Customer)
				.WithOne(RepairInvoice => RepairInvoice.RepairInvoice)
				.HasForeignKey<RepairInvoice>(key => key.Id);
			});

			modelBuilder.Entity<TeamOfWorker>(entity =>
			{
				entity.HasOne(ConstructionRepair => ConstructionRepair.ConstructionRepair)
				.WithOne(TeamOfWorker => TeamOfWorker.TeamOfWorker)
				.HasForeignKey<TeamOfWorker>(key => key.Id);
			});

			modelBuilder.Entity<Worker>(entity =>
			{
				entity.HasOne(TeamOfWorker => TeamOfWorker.TeamOfWorker)
				.WithOne(Worker => Worker.Worker)
				.HasForeignKey<Worker>(key => key.Id);
			});
		}
	}
}