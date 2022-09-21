namespace LaboratoryWorkOnDataBases
{
	internal class Customer : Person
	{
		public string Address { get; set; } = null!;

		public int RepairInvoiceId { get; set; }

		public RepairInvoice RepairInvoice { get; set; } = null!;

		public Order Order { get; set; } = null!;
	}
}