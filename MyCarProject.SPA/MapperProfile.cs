using AutoMapper;
using MyCarProject.SPA.Models;
using OnebrbApi;

namespace MyCarProject.SPA
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region Vehicle
            CreateMap<VehicleResponseModel, VehicleModel>();
            #endregion
        }
    }
}
