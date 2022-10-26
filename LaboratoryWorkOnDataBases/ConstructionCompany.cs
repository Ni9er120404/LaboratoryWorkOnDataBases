namespace LaboratoryWorkOnDataBases
{
	internal class ConstructionCompany
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public string? INN { get; set; }

		public string? Address { get; set; }

		public List<ConstructionRepair> ConstructionRepair { get; set; } = new();

		public List<Order>? Orders { get; set; } = new();
	}
}