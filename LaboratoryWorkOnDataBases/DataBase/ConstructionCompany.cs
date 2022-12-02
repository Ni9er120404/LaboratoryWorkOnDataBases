namespace LaboratoryWorkOnDataBases
{
	internal class ConstructionCompany
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public string? INN { get; set; }

		public string? Address { get; set; }

		public IEnumerable<ConstructionRepair>? ConstructionRepair { get; set; }

		public IEnumerable<Order>? Orders { get; set; }
	}
}