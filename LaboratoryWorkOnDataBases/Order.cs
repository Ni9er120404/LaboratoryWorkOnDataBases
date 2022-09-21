namespace LaboratoryWorkOnDataBases
{
	internal class Order
	{
		public int Id { get; set; }

		public DateTime DateTime { get; set; }

		public int RepairInvoiceId { get; set; }

		public RepairInvoice RepairInvoice { get; set; } = null!;

		public List<Customer> Customer { get; set; } = new();

		public ConstructionRepair ConstructionRepair { get; set; } = null!;

		public int ConstructionCompanyId { get; set; }

		public ConstructionCompany ConstructionCompany { get; set; } = null!;
	}
}