namespace LaboratoryWorkOnDataBases.Models
{
	public class Customer
	{
		public int Id { get; set; }

		public string Address { get; set; } = null!;

		public string LastName { get; set; } = null!;

		public string FirstName { get; set; } = null!;

		public string PhoneNumber { get; set; } = null!;

		public ICollection<Order> Orders { get; set; } = new List<Order>();

		public ICollection<RepairInvoice> RepairInvoices { get; set; } = new List<RepairInvoice>();

		public override string ToString()
		{
			return $"{Id}: {FirstName} {LastName} - {PhoneNumber} - {Address}";
		}
	}
}