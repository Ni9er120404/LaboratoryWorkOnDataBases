namespace LaboratoryWorkOnDataBases
{
	internal class RepairInvoice
	{
		public int NumberId { get; set; }

		public DateTime DateTime { get; set; }

		public Customer Customer { get; set; } = null!;

		public int CustomerId { get; set; }

		public decimal Cost { get; set; }
	}
}