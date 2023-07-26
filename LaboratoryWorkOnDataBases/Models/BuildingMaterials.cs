namespace LaboratoryWorkOnDataBases.Models
{
	public class BuildingMaterials
	{
		public int Id { get; set; }

		public int Count { get; set; }

		public string Action { get; set; } = null!;

		public int TeamOfWorkerId { get; set; }

		public TeamOfWorker TeamOfWorker { get; set; } = null!;

		public override string ToString()
		{
			return $"{Id}: Count - {Count}, Action - {Action}, TeamOfWorker - {TeamOfWorker}";
		}
	}
}