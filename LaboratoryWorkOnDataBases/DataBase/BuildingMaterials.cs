namespace LaboratoryWorkOnDataBases
{
	internal class BuildingMaterials
	{
		public int Id { get; set; }

		public int Count { get; set; }

		public string? Action { get; set; }

		public TeamOfWorker? TeamOfWorker { get; set; }

		public int? TeamOfWorkerId { get; set; }
	}
}