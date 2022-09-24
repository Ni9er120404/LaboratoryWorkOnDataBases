namespace LaboratoryWorkOnDataBases
{
	internal class ConstructionCompany
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string Inn { get; set; } = null!;

		public string Address { get; set; } = null!;

		public ConstructionRepair? ConstructionRepair { get; set; }

		public Order? Order { get; set; }
	}
}