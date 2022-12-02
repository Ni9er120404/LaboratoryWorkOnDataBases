namespace LaboratoryWorkOnDataBases
{
	internal class Customer
	{
		public int Id { get; set; }

		public string? Address { get; set; }

		public string? LastName { get; set; }

		public string? FirstName { get; set; }

		public string? PhoneNumber { get; set; }

		public IEnumerable<Order>? Orders { get; set; }

		public IEnumerable<RepairInvoice>? RepairInvoices { get; set; }
	}
}