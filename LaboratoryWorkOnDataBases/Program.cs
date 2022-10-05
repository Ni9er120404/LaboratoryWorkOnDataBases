using System.Text;

namespace LaboratoryWorkOnDataBases
{
	internal class Program
	{
		private static string Text { get; set; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

		private static string TextWithNumber { get; set; } = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

		private static string Numbers { get; set; } = "0123456789";

		private static Random Random { get; set; } = new Random();

		private static void Main()
		{
			ConstructionCompany company = new(RandomInfo(Text), RandomInfo(TextWithNumber), RandomInfo(TextWithNumber));
			Order[] orders = new Order[10];
			ConstructionRepair[] constructionRepairs = new ConstructionRepair[10];
			Customer[] customers = new Customer[10];

			for (int i = 0; i < 10; i++)
			{
				orders[i] = new Order(Random.Next(100000, 100000000), DateTime.Now);
				customers[i] = new Customer(RandomInfo(TextWithNumber), RandomInfo(Text), RandomInfo(Text), RandomInfo(Numbers));
				constructionRepairs[i] = new ConstructionRepair(RandomInfo(TextWithNumber), Random.Next(20, 200), RandomInfo(Text));
			}
			
			try
			{
				using (Context context = new())
				{
					context.ConstructionCompanies.Add(company);
					context.AddRange(orders);

					context.SaveChanges();
				}

				Console.WriteLine("Процесс выполнен успешно");
			}
			catch (InvalidOperationException)
			{
				Console.WriteLine("Исключение недопустимой операции");
			}
		}

		private static string RandomInfo(string text)
		{
			Random random = new(DateTime.Now.Millisecond);

			StringBuilder stringBuilder = new();

			int index = random.Next(0, text.Length);

			for (int i = 0; i < 10; i++)
			{
				stringBuilder.Append(text[index]);
			}

			return stringBuilder.ToString();
		}
	}
}