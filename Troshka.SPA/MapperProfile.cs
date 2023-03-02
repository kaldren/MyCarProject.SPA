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
            CreateMap<CarBrandResponseModel, VehicleBrandModel>();
            CreateMap<CarModelResponseModel, VehicleModelModel>();
            CreateMap<CarEngineResponseModel, VehicleEngineModel>();
            CreateMap<CarTransmissionResponseModel, VehicleTransmissionModel>();
            CreateMap<CarOfferResponseModel, CarOfferModel>();
            CreateMap<CarOfferEntity, CarOfferModel>();
            CreateMap<CarOfferImagesResponseModel, CarOfferImagesModel>();
            CreateMap<VehicleOwnerResponseModel, VehicleOwnerModel>();

            CreateMap<CategoryResponseModel, VehicleCategoryModel>();
            //CreateMap<VehicleEquipment, CarEquipmentModel>();
            //CreateMap<VehicleImageResponseModel, VehicleImageModel>();
            #endregion
        }
    }
}
