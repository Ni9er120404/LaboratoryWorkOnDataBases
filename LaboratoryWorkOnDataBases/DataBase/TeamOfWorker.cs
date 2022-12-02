namespace LaboratoryWorkOnDataBases
{
    internal class TeamOfWorker
    {
        public int Id { get; set; }

        public int? CountOfWorker { get; set; }

        public DateTime DateOnly { get; set; }

        public ConstructionRepair? ConstructionRepair { get; set; }

        public int? ConstructionRepairsId { get; set; }

        public IEnumerable<Worker>? Worker { get; set; }

        public int? WorkerId { get; set; }

        public IEnumerable<BuildingMaterials>? Materials { get; set; }

        public int? BuildingMaterialsId { get; set; }
    }
}