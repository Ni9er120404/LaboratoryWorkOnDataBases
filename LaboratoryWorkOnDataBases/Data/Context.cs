using LaboratoryWorkOnDataBases.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratoryWorkOnDataBases.Data
{
	public class Context : DbContext
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
			_ = Database.EnsureDeleted();
			_ = Database.EnsureCreated();
		}


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			_ = optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LaboratoryWorkOnDataBases;Trusted_Connection=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			_ = modelBuilder.Entity<ConstructionRepair>(entity =>
			{
				_ = entity.HasOne(repair => repair.ConstructionCompany)
					.WithMany(company => company.ConstructionRepairs)
					.HasForeignKey(repair => repair.ConstructionCompanyId);

				_ = entity.HasOne(repair => repair.TeamOfWorker)
					.WithOne(worker => worker.ConstructionRepair)
					.HasForeignKey<TeamOfWorker>(worker => worker.ConstructionRepairId);
			});

			_ = modelBuilder.Entity<Customer>(entity =>
			{
				_ = entity.HasMany(customer => customer.Orders)
					.WithOne(order => order.Customer)
					.HasForeignKey(order => order.CustomerId);

				_ = entity.HasMany(customer => customer.RepairInvoices)
					.WithOne(invoice => invoice.Customer)
					.HasForeignKey(invoice => invoice.CustomerId);
			});

			_ = modelBuilder.Entity<Order>(entity =>
			{
				_ = entity.HasOne(order => order.ConstructionCompany)
					.WithMany(company => company.Orders)
					.HasForeignKey(order => order.ConstructionCompanyId);

				_ = entity.HasOne(order => order.Customer)
					.WithMany(customer => customer.Orders)
					.HasForeignKey(order => order.CustomerId);
			});

			_ = modelBuilder.Entity<RepairInvoice>(entity =>
			{
				_ = entity.HasOne(invoice => invoice.Customer)
					.WithMany(customer => customer.RepairInvoices)
					.HasForeignKey(invoice => invoice.CustomerId);
			});

			_ = modelBuilder.Entity<TeamOfWorker>(entity =>
			{
				_ = entity.HasMany(team => team.Workers)
					.WithOne(worker => worker.TeamOfWorker)
					.HasForeignKey(worker => worker.TeamOfWorkerId);

				_ = entity.HasMany(team => team.Materials)
					.WithOne(material => material.TeamOfWorker)
					.HasForeignKey(material => material.TeamOfWorkerId);
			});

			_ = modelBuilder.Entity<Worker>(entity =>
			{
				_ = entity.HasOne(worker => worker.TeamOfWorker)
					.WithMany(team => team.Workers)
					.HasForeignKey(worker => worker.TeamOfWorkerId);
			});

			_ = modelBuilder.Entity<BuildingMaterials>(entity =>
			{
				_ = entity.HasOne(material => material.TeamOfWorker)
					.WithMany(team => team.Materials)
					.HasForeignKey(material => material.TeamOfWorkerId);
			});

			base.OnModelCreating(modelBuilder);
		}
	}
}