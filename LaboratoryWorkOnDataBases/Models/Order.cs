namespace LaboratoryWorkOnDataBases.Models
{
	public class Order
	{
		public int Id { get; set; }

		public decimal Price { get; set; }

		public DateTime DateOnly { get; set; }

		public int CustomerId { get; set; }

		public Customer Customer { get; set; } = null!;

		public int ConstructionCompanyId { get; set; }

		public ConstructionCompany ConstructionCompany { get; set; } = null!;

		public override string ToString()
		{
			return $"{Id}: Price - {Price}, Date - {DateOnly}, Customer - {Customer}, ConstructionCompany - {ConstructionCompany}";
		}
	}
}