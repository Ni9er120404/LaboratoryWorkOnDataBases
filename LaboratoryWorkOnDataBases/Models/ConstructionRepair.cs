namespace LaboratoryWorkOnDataBases.Models
{
	public class ConstructionRepair
	{
		public int Id { get; set; }

		public string Address { get; set; } = null!;

		public double Square { get; set; }

		public string Kind { get; set; } = null!;

		public int ConstructionCompanyId { get; set; }

		public ConstructionCompany ConstructionCompany { get; set; } = null!;

		public int TeamOfWorkerId { get; set; }

		public TeamOfWorker TeamOfWorker { get; set; } = null!;

		public override string ToString()
		{
			return $"{Id}: {Address} - {Square} - {Kind}";
		}
	}
}