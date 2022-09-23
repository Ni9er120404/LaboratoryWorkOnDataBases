namespace LaboratoryWorkOnDataBases
{
	internal class Worker
	{
		public int Id { get; set; }

		public decimal Salary { get; set; }

		public string LastName { get; set; } = null!;

		public string FirstName { get; set; } = null!;

		public string PhoneNumber { get; set; } = null!;

		public virtual TeamOfWorker IdNavigation { get; set; } = null!;
	}
}