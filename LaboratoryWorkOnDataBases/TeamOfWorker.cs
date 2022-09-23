namespace LaboratoryWorkOnDataBases
{
	internal class TeamOfWorker
	{
		public int Id { get; set; }

		public virtual ConstructionRepair IdNavigation { get; set; } = null!;

		public virtual Worker? Worker { get; set; }
	}
}