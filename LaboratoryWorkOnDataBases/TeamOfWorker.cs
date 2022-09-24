namespace LaboratoryWorkOnDataBases
{
	internal class TeamOfWorker
	{
		public int Id { get; set; }

		public ConstructionRepair ConstructionRepair { get; set; } = null!;

		public Worker? Worker { get; set; }
	}
}