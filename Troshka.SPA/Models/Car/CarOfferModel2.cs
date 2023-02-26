using OnebrbApi;

namespace Troshka.SPA.Models.Car
{
    public class CarOfferModel2
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual OwnerEntity Owner { get; set; }
        public virtual CarSpecificationEntity Specification { get; set; }
        public virtual CarEquipmentEntity Equipment { get; set; }
    }
}
