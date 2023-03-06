using AutoMapper;
using Troshka.SPA.Models;
using Troshka.SPA.Models.Car;
using Troshka.SPA.Models.Common;
using TroshkaApi;

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
            CreateMap<RegionResponseModel, CommonRegionModel>();
            CreateMap<LocationResponseModel, CommonLocationModel>();
            #endregion
        }
    }
}
