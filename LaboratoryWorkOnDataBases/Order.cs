﻿namespace LaboratoryWorkOnDataBases
{
	internal class Order
	{
		public int Id { get; set; }

		public decimal Price { get; set; }

		public DateTime DateTime { get; set; }

		public Customer? Customer { get; set; }

		public int CustomerId { get; set; }

		public ConstructionCompany ConstructionCompany { get; set; } = null!;

		public int ConstructionCompanyId { get; set; }
	}
}