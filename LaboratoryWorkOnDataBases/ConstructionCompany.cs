namespace LaboratoryWorkOnDataBases
{
	internal class ConstructionCompany
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string INN { get; set; } = null!;

		public string Address { get; set; } = null!;

		public List<Order> Orders { get; set; } = new();
	}
}