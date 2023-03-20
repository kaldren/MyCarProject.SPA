namespace Troshka.SPA.Models.Car
{
    public class VehicleSearchRequestModel
    {
        public string Category { get; set; }

        public string BrandId { get; set; }
        public string ModelId { get; set; }
        public string Year { get; set; }
        public string RegionId { get; set; }
        public string LocationId { get; set; }
        public string EngineId { get; set; }
        public string TransmissionId { get; set; }
        public bool IsRegistered { get; set; }

        public CarOfferFilters Filters { get; set; } = new();
    }
}
