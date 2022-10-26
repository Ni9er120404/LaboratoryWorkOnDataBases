namespace LaboratoryWorkOnDataBases
{
	internal class TeamOfWorker
	{
		public int Id { get; set; }

		public int CountOfWorker { get; set; }

		public ConstructionRepair? ConstructionRepair { get; set; }

		public List<Worker> Worker { get; set; } = new();

		public int WorkerId { get; set; }

		public List<BuildingMaterials> Materials { get; set; } = new();

		public int BuildingMaterialsId { get; set; }
	}
}