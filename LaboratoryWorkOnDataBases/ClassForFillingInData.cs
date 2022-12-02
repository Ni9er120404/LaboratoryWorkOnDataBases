using System.Text;

namespace LaboratoryWorkOnDataBases
{
	internal class ClassForFillingInData
	{
		private readonly string _text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

		private readonly string _numbers = "0123456789";

		private readonly Random _random = new();

		private readonly string[] _action = { "Ведутся работы", "Работа закончена" };

		private string Completion(int a, int b)
		{
			int num = _random.Next(a, b);
			
			StringBuilder stringBuilder = new();

			for (int i = 0; i < num; i++)
			{
				_ = stringBuilder.Append(_text[_random.Next(0, _text.Length)]);
			}

			return stringBuilder.ToString();
		}

		private string Completion()
		{
			StringBuilder stringBuilder = new();
			
			for (int i = 0; i < 10; i++)
			{
				_ = stringBuilder.Append(_numbers[_random.Next(0, _numbers.Length)]);
			}
			
			return string.Concat("8", stringBuilder.ToString());
		}

		public BuildingMaterials[] BuildingMaterialsCompletion(int number)
		{

			BuildingMaterials[] BuildingMaterials = new BuildingMaterials[number];

			for (int i = 0; i < BuildingMaterials.Length; i++)
			{
				BuildingMaterials[i] = new()
				{
					Action = _action[_random.Next(0, 2)],
					Count = _random.Next(0, 10000)
				};
			}


			return BuildingMaterials;
		}

		public ConstructionCompany[] ConstructionCompanyCompletion(int number)
		{
			ConstructionCompany[] ConstructionCompanies = new ConstructionCompany[number];

			for (int i = 0; i < ConstructionCompanies.Length; i++)
			{
				ConstructionCompanies[i] = new()
				{
					Name = Completion(10, 20),
					INN = Completion(),
					Address = Completion(10, 20)
				};
			}

			return ConstructionCompanies;
		}

		public ConstructionRepair[] ConstructionRepairCompletion(int number)
		{
			ConstructionRepair[] ConstructionRepairs = new ConstructionRepair[number];

			for (int i = 0; i < ConstructionRepairs.Length; i++)
			{
				ConstructionRepairs[i] = new()
				{
					Address = Completion(10, 20),
					Square = (double)_random.NextDouble(),
					Kind = Completion(10, 20)
				};
			}

			return ConstructionRepairs;
		}

		public Customer[] CustomerCompletion(int number)
		{
			Customer[] Customers = new Customer[number];

			for (int i = 0; i < Customers.Length; i++)
			{
				Customers[i] = new()
				{
					Address = Completion(10, 20),
					LastName = Completion(10, 20),
					FirstName = Completion(10, 20),
					PhoneNumber = Completion()
				};
			}

			return Customers;
		}

		public Order[] OrderCompletion(int number)
		{
			Order[] Orders = new Order[number];

			for (int i = 0; i < Orders.Length; i++)
			{
				Orders[i] = new()
				{
					Price = _random.Next(100000, 10000000),
					DateOnly = DateTime.Now
				};
			}

			return Orders;
		}

		public RepairInvoice[] RepairInvoiceCompletion(int number)
		{
			RepairInvoice[] RepairInvoices = new RepairInvoice[number];

			for (int i = 0; i < RepairInvoices.Length; i++)
			{
				RepairInvoices[i] = new()
				{
					DateOnly = DateTime.Now,
					Cost = _random.Next(100000, 10000000)
				};
			}

			return RepairInvoices;
		}

		public TeamOfWorker[] TeamOfWorkerCompletion(int number)
		{
			TeamOfWorker[] TeamOfWorkers = new TeamOfWorker[number];

			for (int i = 0; i < TeamOfWorkers.Length; i++)
			{
				TeamOfWorkers[i] = new()
				{
					DateOnly = DateTime.Now,
					CountOfWorker = _random.Next(0, 15)
				};
			}

			return TeamOfWorkers;
		}

		public Worker[] WorkerCompletion(int number)
		{
			Worker[] Workers = new Worker[number];

			for (int i = 0; i < Workers.Length; i++)
			{
				Workers[i] = new()
				{
					Salary = (decimal)_random.NextDouble(),
					LastName = Completion(10, 20),
					FirstName = Completion(10, 20),
					PhoneNumber = Completion()
				};
			}

			return Workers;
		}
	}
}