namespace LaboratoryWorkOnDataBases
{
	internal class ConstructionRepair
	{
		public int Id { get; set; }

		public string Address { get; set; } = null!;

		public double Square { get; set; }

		public string Kind { get; set; } = null!;

		public List<Worker> Workers { get; set; } = new();
	}
}