using LaboratoryWorkOnDataBases.Data;
using LaboratoryWorkOnDataBases.Models;

namespace LaboratoryWorkOnDataBases
{
	public class Program
	{
		private static void Main()
		{
			using Context context = new();

			DataSeeder.SeedData(context);

			DisplayData(context);

			_ = context.SaveChanges();
		}

		private static void DisplayData(Context context)
		{
			Console.WriteLine("Construction Companies:");
			foreach (ConstructionCompany company in context.ConstructionCompanies)
			{
				Console.WriteLine(company);
			}

			Console.WriteLine("\nCustomers:");
			foreach (Customer customer in context.Customers)
			{
				Console.WriteLine(customer);
			}

			Console.WriteLine("\nConstruction Repairs:");
			foreach (ConstructionRepair repair in context.ConstructionRepairs)
			{
				Console.WriteLine(repair);
			}

			Console.WriteLine("\nOrders:");
			foreach (Order order in context.Orders)
			{
				Console.WriteLine(order);
			}

			Console.WriteLine("\nRepair Invoices:");
			foreach (RepairInvoice invoice in context.RepairInvoices)
			{
				Console.WriteLine(invoice);
			}

			Console.WriteLine("\nTeam of Workers:");
			foreach (TeamOfWorker team in context.TeamOfWorkers)
			{
				Console.WriteLine(team);
			}

			Console.WriteLine("\nWorkers:");
			foreach (Worker worker in context.Workers)
			{
				Console.WriteLine(worker);
			}

			Console.WriteLine("\nBuilding Materials:");
			foreach (BuildingMaterials material in context.BuildingMaterials)
			{
				Console.WriteLine(material);
			}

			Console.WriteLine("\nPress any key to exit...");
			_ = Console.ReadKey();
		}
	}
}