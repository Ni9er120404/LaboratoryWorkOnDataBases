namespace LaboratoryWorkOnDataBases
{
	internal class ConstructionRepair
	{
		public int Id { get; set; }

		public string Address { get; set; } = null!;

		public double Square { get; set; }

		public string Kind { get; set; } = null!;

		public ConstructionCompany ConstructionCompany { get; set; } = null!;

		public int ConstructionCompanyId { get; set; }

		public TeamOfWorker? TeamOfWorker { get; set; }

		public ConstructionRepair(string address, double square, string kind)
		{
			Address = address;
			Square = square;
			Kind = kind;
		}
	}
}