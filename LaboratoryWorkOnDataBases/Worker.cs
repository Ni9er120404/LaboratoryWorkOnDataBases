namespace LaboratoryWorkOnDataBases
{
	internal class Worker : Person
	{
		public decimal Salary { get; set; }

		public ConstructionRepair ConstructionRepair { get; set; } = null!;

		public int ConstructionRepairId { get; set; }
	}
}