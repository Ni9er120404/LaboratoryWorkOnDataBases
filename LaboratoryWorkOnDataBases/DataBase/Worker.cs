namespace LaboratoryWorkOnDataBases
{
	internal class Worker
	{
		public int Id { get; set; }

		public decimal Salary { get; set; }

		public string? LastName { get; set; }

		public string? FirstName { get; set; }

		public string? PhoneNumber { get; set; }

		public TeamOfWorker? TeamOfWorker { get; set; }

		public int? TeamOfWorkerId { get; set; }
	}
}