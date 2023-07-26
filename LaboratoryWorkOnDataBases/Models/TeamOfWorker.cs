namespace LaboratoryWorkOnDataBases.Models
{
	public class TeamOfWorker
	{
		public int Id { get; set; }

		public int CountOfWorker { get; set; }

		public DateTime DateOnly { get; set; }

		public int ConstructionRepairId { get; set; }

		public ConstructionRepair ConstructionRepair { get; set; } = null!;

		public ICollection<Worker> Workers { get; set; } = new List<Worker>();

		public int WorkerId { get; set; }

		public ICollection<BuildingMaterials> Materials { get; set; } = new List<BuildingMaterials>();

		public int BuildingMaterialsId { get; set; }

		public override string ToString()
		{
			return $"{Id}: CountOfWorker - {CountOfWorker}, DateOnly - {DateOnly}, ConstructionRepair - {ConstructionRepair}";
		}
	}
}