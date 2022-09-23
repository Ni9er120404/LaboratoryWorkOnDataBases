namespace LaboratoryWorkOnDataBases
{
	internal class ConstructionRepair
	{
		public int Id { get; set; }

		public string Address { get; set; } = null!;

		public double Square { get; set; }

		public string Kind { get; set; } = null!;

		public virtual ConstructionCompany IdNavigation { get; set; } = null!;

		public virtual TeamOfWorker? TeamOfWorker { get; set; }
	}
}