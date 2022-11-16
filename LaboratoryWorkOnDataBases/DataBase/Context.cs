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

		public DbSet<LoggingClass> LoggingClasses { get; set; }

		public Context()
		{
			_ = Database.EnsureDeleted();
			_ = Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			_ = optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LaboratoryWorkOnDataBase;Trusted_Connection=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			_ = modelBuilder.Entity<ConstructionRepair>(entity =>
			{
				_ = entity.HasOne(ConstructionCompany => ConstructionCompany.ConstructionCompany)
				.WithMany(ConstructionRepair => ConstructionRepair.ConstructionRepair)
				.HasForeignKey(key => key.ConstructionCompanyId);
			});

			_ = modelBuilder.Entity<Customer>(entity =>
			{
				_ = entity.HasMany(Order => Order.Orders)
				.WithOne(Customer => Customer.Customer)
				.HasForeignKey(key => key.CustomerId);
			});

			_ = modelBuilder.Entity<Order>(entity =>
			{
				_ = entity.HasOne(ConstructionCompany => ConstructionCompany.ConstructionCompany)
				.WithMany(Order => Order.Orders)
				.HasForeignKey(key => key.ConstructionCompanyId);

				_ = entity.HasOne(Customer => Customer.Customer)
				.WithMany(Order => Order.Orders)
				.HasForeignKey(key => key.CustomerId);
			});

			_ = modelBuilder.Entity<RepairInvoice>(entity =>
			{
				_ = entity.HasOne(Customer => Customer.Customer)
				.WithMany(RepairInvoice => RepairInvoice.RepairInvoices)
				.HasForeignKey(key => key.CustomerId);
			});

			_ = modelBuilder.Entity<TeamOfWorker>(entity =>
			{
				_ = entity.HasOne(ConstructionRepair => ConstructionRepair.ConstructionRepair)
				.WithOne(TeamOfWorker => TeamOfWorker.TeamOfWorker)
				.HasForeignKey<TeamOfWorker>(key => key.Id);

				_ = entity.HasMany(Worker => Worker.Worker)
				.WithOne(TeamOfWorker => TeamOfWorker.TeamOfWorker)
				.HasForeignKey(key => key.TeamOfWorkerId);

				_ = entity.HasMany(BuildingMaterials => BuildingMaterials.Materials)
				.WithOne(TeamOfWorker => TeamOfWorker.TeamOfWorker)
				.HasForeignKey(key => key.TeamOfWorkerId);
			});

			_ = modelBuilder.Entity<Worker>(entity =>
			{
				_ = entity.HasOne(TeamOfWorker => TeamOfWorker.TeamOfWorker)
				.WithMany(Worker => Worker.Worker)
				.HasForeignKey(key => key.TeamOfWorkerId);
			});

			_ = modelBuilder.Entity<BuildingMaterials>(entity =>
			{
				_ = entity.HasOne(TeamOfWorker => TeamOfWorker.TeamOfWorker)
				.WithMany(Materials => Materials.Materials)
				.HasForeignKey(key => key.TeamOfWorkerId);
			});
		}
	}
}