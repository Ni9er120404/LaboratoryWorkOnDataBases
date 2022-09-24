namespace LaboratoryWorkOnDataBases
{
	internal class Customer
	{
		public int Id { get; set; }

		public string Address { get; set; } = null!;

		public string LastName { get; set; } = null!;

		public string FirstName { get; set; } = null!;

		public string PhoneNumber { get; set; } = null!;

		public Order Order { get; set; } = null!;

		public RepairInvoice? RepairInvoice { get; set; }
	}
}