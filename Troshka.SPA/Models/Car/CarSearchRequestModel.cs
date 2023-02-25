namespace Troshka.SPA.Models.Car
{
    public class CarSearchRequestModel
    {
        public CategoryModel Category { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
