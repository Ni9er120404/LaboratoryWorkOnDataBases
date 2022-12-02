﻿namespace LaboratoryWorkOnDataBases
{
	internal class ConstructionRepair
	{
		public int Id { get; set; }

		public string? Address { get; set; }

		public double Square { get; set; }

		public string? Kind { get; set; }

		public ConstructionCompany? ConstructionCompany { get; set; }

		public int? ConstructionCompanyId { get; set; }

		public TeamOfWorker? TeamOfWorker { get; set; }

		public int? TeamOfWorkerId { get; set; }
	}
}