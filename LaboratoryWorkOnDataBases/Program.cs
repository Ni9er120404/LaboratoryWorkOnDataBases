using Microsoft.EntityFrameworkCore;

namespace LaboratoryWorkOnDataBases
{
	internal class Program
	{
		private static void Main()
		{
			try
			{
				using (Context context = new())
				{
				
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