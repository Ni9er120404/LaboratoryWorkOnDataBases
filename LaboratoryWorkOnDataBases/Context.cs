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

		public DbSet<BuildingMaterials> BuildingMaterials { get; set; }

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
				.WithMany(ConstructionRepair => ConstructionRepair.ConstructionRepair)
				.HasForeignKey(key => key.ConstructionCompanyId);
			});

			modelBuilder.Entity<Customer>(entity =>
			{
				entity.HasMany(Order => Order.Orders)
				.WithOne(Customer => Customer.Customer)
				.HasForeignKey(key => key.CustomerId);
			});

			modelBuilder.Entity<Order>(entity =>
			{
				entity.HasOne(ConstructionCompany => ConstructionCompany.ConstructionCompany)
				.WithMany(Order => Order.Orders)
				.HasForeignKey(key => key.ConstructionCompanyId);
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
				.WithMany(Worker => Worker.Worker)
				.HasForeignKey(key => key.TeamOfWorkerId);
			});

			modelBuilder.Entity<BuildingMaterials>(entity =>
			{
				entity.HasOne(TeamOfWorker => TeamOfWorker.TeamOfWorker)
				.WithMany(Materials => Materials.Materials)
				.HasForeignKey(key => key.TeamOfWorkerId);
			});
		}
	}
}