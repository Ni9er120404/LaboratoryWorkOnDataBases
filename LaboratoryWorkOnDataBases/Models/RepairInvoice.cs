namespace LaboratoryWorkOnDataBases.Models
{
	public class RepairInvoice
	{
		public int Id { get; set; }

		public DateTime DateOnly { get; set; }

		public decimal Cost { get; set; }

		public int CustomerId { get; set; }

		public Customer Customer { get; set; } = null!;

		public override string ToString()
		{
			return $"{Id}: Date - {DateOnly}, Cost - {Cost}, Customer - {Customer}";
		}
	}
}