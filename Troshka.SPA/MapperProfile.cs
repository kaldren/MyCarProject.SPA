using AutoMapper;
using OnebrbApi;
using Troshka.SPA.Models;
using Troshka.SPA.Models.Car;

namespace Troshka.SPA
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region Vehicle
            CreateMap<CarOfferResponseModel, CarOfferModel>();
            CreateMap<CarOfferImagesResponseModel, CarOfferImagesModel>();
            CreateMap<VehicleOwnerResponseModel, OwnerModel>();

            CreateMap<CategoryResponseModel, CategoryModel>();
            //CreateMap<VehicleEquipment, CarEquipmentModel>();
            //CreateMap<VehicleImageResponseModel, VehicleImageModel>();
            #endregion
        }
    }
}
