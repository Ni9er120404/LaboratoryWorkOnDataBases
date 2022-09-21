namespace LaboratoryWorkOnDataBases
{
	internal class RepairInvoice
	{
		public int NumberId { get; set; }

		public DateTime DateTime { get; set; }

		public List<Customer> Customers { get; set; } = new();

		public int CustomerId { get; set; }

		public decimal Cost { get; set; }
	}
}