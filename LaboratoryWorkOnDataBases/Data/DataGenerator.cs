using LaboratoryWorkOnDataBases.Models;

namespace LaboratoryWorkOnDataBases.Data
{
	internal static class DataSeeder
	{
		public static void SeedData(Context context)
		{
			List<ConstructionCompany> constructionCompanies = GenerateConstructionCompanies(5);
			List<Customer> customers = GenerateCustomers(10);
			List<ConstructionRepair> constructionRepairs = GenerateConstructionRepairs(constructionCompanies, 15);
			List<Order> orders = GenerateOrders(constructionCompanies, customers, 20);
			List<RepairInvoice> repairInvoices = GenerateRepairInvoices(customers, 15);
			List<TeamOfWorker> teamOfWorkers = GenerateTeamOfWorkers(constructionRepairs, 10);
			List<Worker> workers = GenerateWorkers(teamOfWorkers, 30);
			List<BuildingMaterials> buildingMaterials = GenerateBuildingMaterials(teamOfWorkers, 25);

			context.ConstructionCompanies.AddRange(constructionCompanies);
			context.Customers.AddRange(customers);
			context.ConstructionRepairs.AddRange(constructionRepairs);
			context.Orders.AddRange(orders);
			context.RepairInvoices.AddRange(repairInvoices);
			context.TeamOfWorkers.AddRange(teamOfWorkers);
			context.Workers.AddRange(workers);
			context.BuildingMaterials.AddRange(buildingMaterials);

			_ = context.SaveChanges();
		}

		private static List<ConstructionCompany> GenerateConstructionCompanies(int count)
		{
			List<ConstructionCompany> companies = new();

			for (int i = 0; i < count; i++)
			{
				companies.Add(new()
				{
					Name = $"Construction Company {i + 1}",
					INN = GenerateRandomString(10),
					Address = $"Address {i + 1}"
				});
			}

			return companies;
		}

		private static List<Customer> GenerateCustomers(int count)
		{
			List<Customer> customers = new();

			for (int i = 0; i < count; i++)
			{
				customers.Add(new()
				{
					FirstName = $"Customer First Name {i + 1}",
					LastName = $"Customer Last Name {i + 1}",
					PhoneNumber = GenerateRandomPhoneNumber(),
					Address = $"Customer Address {i + 1}"
				});
			}

			return customers;
		}

		private static List<ConstructionRepair> GenerateConstructionRepairs(List<ConstructionCompany> companies, int count)
		{
			List<ConstructionRepair> repairs = new();

			for (int i = 0; i < count; i++)
			{
				ConstructionCompany randomCompany = companies[GenerateRandomNumber(0, companies.Count - 1)];
				repairs.Add(new()
				{
					Address = $"Repair Address {i + 1}",
					Square = GenerateRandomNumber(50, 500),
					Kind = $"Repair Kind {i + 1}",
					ConstructionCompany = randomCompany
				});
			}

			return repairs;
		}

		private static List<Order> GenerateOrders(List<ConstructionCompany> companies, List<Customer> customers, int count)
		{
			List<Order> orders = new();

			for (int i = 0; i < count; i++)
			{
				ConstructionCompany randomCompany = companies[GenerateRandomNumber(0, companies.Count - 1)];

				Customer randomCustomer = customers[GenerateRandomNumber(0, customers.Count - 1)];

				orders.Add(new()
				{
					Price = GenerateRandomNumber(1000, 10000),
					DateOnly = DateTime.Now.AddDays(-GenerateRandomNumber(1, 30)),
					ConstructionCompany = randomCompany,
					Customer = randomCustomer
				});
			}

			return orders;
		}

		private static List<RepairInvoice> GenerateRepairInvoices(List<Customer> customers, int count)
		{
			List<RepairInvoice> invoices = new();

			for (int i = 0; i < count; i++)
			{
				Customer randomCustomer = customers[GenerateRandomNumber(0, customers.Count - 1)];

				invoices.Add(new()
				{
					DateOnly = DateTime.Now.AddDays(-GenerateRandomNumber(1, 30)),
					Cost = GenerateRandomNumber(500, 5000),
					Customer = randomCustomer
				});
			}

			return invoices;
		}

		private static List<TeamOfWorker> GenerateTeamOfWorkers(List<ConstructionRepair> repairs, int count)
		{
			List<TeamOfWorker> teams = new();

			for (int i = 0; i < count; i++)
			{
				ConstructionRepair randomRepair = repairs[GenerateRandomNumber(0, repairs.Count - 1)];

				teams.Add(new()
				{
					CountOfWorker = GenerateRandomNumber(5, 20),
					DateOnly = DateTime.Now.AddDays(-GenerateRandomNumber(1, 30)),
					ConstructionRepair = randomRepair
				});
			}

			return teams;
		}

		private static List<Worker> GenerateWorkers(List<TeamOfWorker> teams, int count)
		{
			List<Worker> workers = new();

			for (int i = 0; i < count; i++)
			{
				TeamOfWorker randomTeam = teams[GenerateRandomNumber(0, teams.Count - 1)];

				workers.Add(new()
				{
					Salary = GenerateRandomNumber(1000, 5000),
					FirstName = $"Worker First Name {i + 1}",
					LastName = $"Worker Last Name {i + 1}",
					PhoneNumber = GenerateRandomPhoneNumber(),
					TeamOfWorker = randomTeam
				});
			}

			return workers;
		}

		private static List<BuildingMaterials> GenerateBuildingMaterials(List<TeamOfWorker> teams, int count)
		{
			List<BuildingMaterials> materials = new();

			for (int i = 0; i < count; i++)
			{
				TeamOfWorker randomTeam = teams[GenerateRandomNumber(0, teams.Count - 1)];

				materials.Add(new()
				{
					Count = GenerateRandomNumber(100, 500),
					Action = $"Material Action {i + 1}",
					TeamOfWorker = randomTeam
				});
			}

			return materials;
		}

		private static int GenerateRandomNumber(int min, int max)
		{
			Random random = new();

			return random.Next(min, max + 1);
		}

		private static string GenerateRandomString(int length)
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			Random random = new();

			return new string(Enumerable.Repeat(chars, length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}

		private static string GenerateRandomPhoneNumber()
		{
			Random random = new();

			return $"+1{random.Next(100, 999)}-{random.Next(100, 999)}-{random.Next(1000, 9999)}";
		}
	}
}