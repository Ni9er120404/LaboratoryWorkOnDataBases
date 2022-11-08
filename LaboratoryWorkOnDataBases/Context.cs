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
			//Database.EnsureDeleted();
			//Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LaboratoryWorkOnDataBase;Trusted_Connection=True;");
			//optionsBuilder.LogTo(Console.WriteLine);
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

				entity.HasOne(Customer => Customer.Customer)
				.WithMany(Order => Order.Orders)
				.HasForeignKey(key => key.CustomerId);
			});

			modelBuilder.Entity<RepairInvoice>(entity =>
			{
				entity.HasOne(Customer => Customer.Customer)
				.WithMany(RepairInvoice => RepairInvoice.RepairInvoices)
				.HasForeignKey(key => key.CustomerId);
			});

			modelBuilder.Entity<TeamOfWorker>(entity =>
			{
				entity.HasOne(ConstructionRepair => ConstructionRepair.ConstructionRepair)
				.WithOne(TeamOfWorker => TeamOfWorker.TeamOfWorker)
				.HasForeignKey<TeamOfWorker>(key => key.Id);

				entity.HasMany(Worker => Worker.Worker)
				.WithOne(TeamOfWorker => TeamOfWorker.TeamOfWorker)
				.HasForeignKey(key => key.TeamOfWorkerId);

				entity.HasMany(BuildingMaterials => BuildingMaterials.Materials)
				.WithOne(TeamOfWorker => TeamOfWorker.TeamOfWorker)
				.HasForeignKey(key => key.TeamOfWorkerId);
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