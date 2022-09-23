using Microsoft.EntityFrameworkCore;

namespace LaboratoryWorkOnDataBases
{
	internal class Context : DbContext
	{
		public DbSet<ConstructionCompany> ConstructionCompanies { get; set; } = null!;

		public DbSet<ConstructionRepair> ConstructionRepairs { get; set; } = null!;

		public DbSet<Customer> Customers { get; set; } = null!;

		public DbSet<Order> Orders { get; set; } = null!;

		public DbSet<RepairInvoice> RepairInvoices { get; set; } = null!;

		public DbSet<TeamOfWorker> TeamOfWorkers { get; set; } = null!;

		public DbSet<Worker> Workers { get; set; } = null!;

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
				entity.HasOne(d => d.IdNavigation).WithOne(p => p.ConstructionRepair).HasForeignKey<ConstructionRepair>(d => d.Id);
			});

			modelBuilder.Entity<Customer>(entity =>
			{
				entity.HasOne(d => d.IdNavigation).WithOne(p => p.Customer).HasForeignKey<Customer>(d => d.Id);
			});

			modelBuilder.Entity<Order>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnOrder(0);
				entity.Property(e => e.DateTime).HasColumnOrder(1);
				entity.HasOne(d => d.IdNavigation).WithOne(p => p.Order).HasForeignKey<Order>(d => d.Id);
			});

			modelBuilder.Entity<RepairInvoice>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnOrder(0);
				entity.Property(e => e.Cost).HasColumnOrder(2).HasColumnType("decimal(18, 2)");
				entity.Property(e => e.DateTime).HasColumnOrder(1);
				entity.HasOne(d => d.IdNavigation).WithOne(p => p.RepairInvoice).HasForeignKey<RepairInvoice>(d => d.Id);
			});

			modelBuilder.Entity<TeamOfWorker>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnOrder(0);
				entity.HasOne(d => d.IdNavigation).WithOne(p => p.TeamOfWorker).HasForeignKey<TeamOfWorker>(d => d.Id);
			});

			modelBuilder.Entity<Worker>(entity =>
			{
				entity.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnOrder(0);
				entity.Property(e => e.FirstName).HasColumnOrder(3);
				entity.Property(e => e.LastName).HasColumnOrder(2);
				entity.Property(e => e.PhoneNumber).HasColumnOrder(4);
				entity.Property(e => e.Salary).HasColumnOrder(1).HasColumnType("decimal(18, 2)");
				entity.HasOne(d => d.IdNavigation).WithOne(p => p.Worker).HasForeignKey<Worker>(d => d.Id);
			});
		}
	}
}