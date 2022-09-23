namespace LaboratoryWorkOnDataBases
{
	internal class ConstructionCompany
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string Inn { get; set; } = null!;

		public string Address { get; set; } = null!;

		public virtual ConstructionRepair? ConstructionRepair { get; set; }

		public virtual Order? Order { get; set; }
	}
}