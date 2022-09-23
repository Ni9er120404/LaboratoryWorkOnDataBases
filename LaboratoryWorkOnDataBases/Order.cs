namespace LaboratoryWorkOnDataBases
{
	internal class Order
	{
		public int Id { get; set; }

		public DateTime DateTime { get; set; }

		public virtual Customer? Customer { get; set; }

		public virtual ConstructionCompany IdNavigation { get; set; } = null!;
	}
}