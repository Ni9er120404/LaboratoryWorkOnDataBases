namespace LaboratoryWorkOnDataBases
{
	internal class Customer
	{
		public int Id { get; set; }

		public string? Address { get; set; }

		public string? LastName { get; set; }

		public string? FirstName { get; set; }

		public string? PhoneNumber { get; set; }

		public List<Order> Orders { get; set; } = new();

		public List<RepairInvoice>? RepairInvoices { get; set; } = new();
	}
}