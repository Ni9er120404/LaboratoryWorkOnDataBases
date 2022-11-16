using System.Text;

namespace LaboratoryWorkOnDataBases
{
	internal class Program
	{
		private static void Main()
		{
			Customer[] customers = new Customer[100];
			for(int i=0; i<customers.Length;i++)
			{
				customers[i] = new Customer()
				{
					Address = Completion(10, 30),
					LastName = Completion(10, 20),
					FirstName = Completion(10, 20),
					PhoneNumber = Completion()
				};
			}
			try
			{
				using (Context context = new())
				{
					context.Customers.AddRange(customers);
					context.SaveChanges();
				}

				Console.WriteLine("Процесс выполнен успешно");
			}
			catch (InvalidOperationException)
			{
				Console.WriteLine("Исключение недопустимой операции");
			}
		}

		private static readonly string Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

		private static readonly string Numbers = "0123456789";

		private static readonly Random Random = new();

		private static string Completion(int a, int b)
		{
			int num = Random.Next(a, b);
			StringBuilder stringBuilder = new();

			for (int i = 0; i < num; i++)
			{
				stringBuilder.Append(Text[Random.Next(0, Text.Length)]);
			}

			return stringBuilder.ToString();
		}

		private static string Completion()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for(int i=0; i<10;i++)
			{
				stringBuilder.Append(Numbers[Random.Next(0, Numbers.Length)]);
			}
			return string.Concat("8",stringBuilder.ToString());
		}
	}
}