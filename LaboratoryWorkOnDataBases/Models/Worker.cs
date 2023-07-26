namespace LaboratoryWorkOnDataBases.Models
{
	public class Worker
	{
		public int Id { get; set; }

		public decimal Salary { get; set; }

		public string LastName { get; set; } = null!;

		public string FirstName { get; set; } = null!;

		public string PhoneNumber { get; set; } = null!;

		public int TeamOfWorkerId { get; set; }

		public TeamOfWorker? TeamOfWorker { get; set; }

		public override string ToString()
		{
			return $"{Id}: Salary - {Salary}, LastName - {LastName}, FirstName - {FirstName}, PhoneNumber - {PhoneNumber}, TeamOfWorker - {TeamOfWorker}";
		}
	}
}