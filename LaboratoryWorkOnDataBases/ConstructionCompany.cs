namespace LaboratoryWorkOnDataBases
{
	internal class ConstructionCompany
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string INN { get; set; } = null!;

		public string Address { get; set; } = null!;

		public List<ConstructionRepair> ConstructionRepair { get; set; } = new();

		public List<Order>? Orders { get; set; } = new();

		public ConstructionCompany(string name, string iNN, string address)
		{
			Name = name;
			INN = iNN;
			Address = address;
		}
	}
}