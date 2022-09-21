namespace LaboratoryWorkOnDataBases
{
	internal class TeamOfWorkers
	{
		public int Id { get; set; }

		internal List<Worker> Workers { get; set; } = new();
	}
}