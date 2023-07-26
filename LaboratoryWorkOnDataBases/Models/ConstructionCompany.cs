namespace LaboratoryWorkOnDataBases.Models
{
	public class ConstructionCompany
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string INN { get; set; } = null!;

		public string Address { get; set; } = null!;

		public ICollection<ConstructionRepair> ConstructionRepairs { get; set; } = new List<ConstructionRepair>();

		public ICollection<Order> Orders { get; set; } = new List<Order>();

		public override string ToString()
		{
			return $"{Id}: {Name} - {INN} - {Address}";
		}
	}
}