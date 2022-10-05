namespace LaboratoryWorkOnDataBases
{
	internal class RepairInvoice
	{
		public int Id { get; set; }

		public DateTime DateTime { get; set; }

		public decimal Cost { get; set; }

		public Customer Customer { get; set; } = null!;

		public RepairInvoice(DateTime dateTime, decimal cost)
		{
			DateTime = dateTime;
			Cost = cost;
		}
	}
}