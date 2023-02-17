using AutoMapper;
using Troshka.SPA.Models;
using OnebrbApi;

namespace Troshka.SPA
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region Vehicle
            CreateMap<VehicleResponseModel, VehicleModel>();
            CreateMap<VehicleSpecification, VehicleSpecificationModel>();
            CreateMap<VehicleEquipment, VehicleEquipmentModel>();
            CreateMap<VehicleImageResponseModel, VehicleImageModel>();
            CreateMap<VehicleOwnerResponseModel, VehicleOwnerModel>();
            #endregion
        }
    }
}
