namespace Troshka.SPA.Models
{
    public class VehicleSpecificationModel
    {
        public int HorsePowers { get; set; }
        public string Category { get; set; }
        public int Mileage { get; set; }
        public string Engine { get; set; }
        public int Euro { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public int Seats { get; set; }
        public string Doors { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public DateTimeOffset FirstRegistration { get; set; }
        public decimal Price { get; set; }
        public bool IsRegistered { get; set; }
        public string InteriorMaterial { get; set; }
        public string InteriorColor { get; set; }
    }
}
