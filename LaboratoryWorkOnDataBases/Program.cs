namespace LaboratoryWorkOnDataBases
{
	internal class Program
	{
		public static BuildingMaterials[]? BuildingMaterials { get; set; }

		public static ConstructionCompany[]? ConstructionCompanies { get; set; }

		public static ConstructionRepair[]? ConstructionRepairs { get; set; }

		public static Customer[]? Customers { get; set; }

		public static Order[]? Orders { get; set; }

		public static RepairInvoice[]? RepairInvoices { get; set; }

		public static TeamOfWorker[]? TeamOfWorkers { get; set; }

		public static Worker[]? Workers { get; set; }

		private static void Main()
		{
			ClassForFillingInData data = new();

			BuildingMaterials = data.BuildingMaterialsCompletion(1000);

			ConstructionCompanies = data.ConstructionCompanyCompletion(2);

			ConstructionRepairs = data.ConstructionRepairCompletion(100);

			Customers = data.CustomerCompletion(100);

			Orders = data.OrderCompletion(100);

			RepairInvoices = data.RepairInvoiceCompletion(100);

			TeamOfWorkers = data.TeamOfWorkerCompletion(25);

			Workers = data.WorkerCompletion(25);

			try
			{
				using (Context context = new())
				{
					context.BuildingMaterials.AddRange(BuildingMaterials);

					context.ConstructionCompanies.AddRange(ConstructionCompanies);

					context.ConstructionRepairs.AddRange(ConstructionRepairs);

					context.Customers.AddRange(Customers);

					context.Orders.AddRange(Orders);

					context.RepairInvoices.AddRange(RepairInvoices);

					context.TeamOfWorkers.AddRange(TeamOfWorkers);

					context.Workers.AddRange(Workers);

					_ = context.SaveChanges();
				}

				Console.WriteLine("Процесс выполнен успешно");
			}
			catch (InvalidOperationException)
			{
				Console.WriteLine("Исключение недопустимой операции");
			}
		}
	}
}