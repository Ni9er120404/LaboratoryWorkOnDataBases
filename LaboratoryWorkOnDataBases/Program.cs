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
			catch (Exception)
			{
				Console.WriteLine("Ошибка подключения");
			}
		}
	}
}