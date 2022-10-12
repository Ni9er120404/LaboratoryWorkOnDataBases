namespace LaboratoryWorkOnDataBases
{
	internal class TeamOfWorker
	{
		public int Id { get; set; }

		public ConstructionRepair ConstructionRepair { get; set; } = null!;

		public List<Worker> Worker { get; set; } = new();

		public List<BuildingMaterials> Materials { get; set; } = new();
	}
}