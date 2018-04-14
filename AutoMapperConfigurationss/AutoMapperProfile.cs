using AutoMapper;
using uow_generic.Core.Domains;
using uow_generic.DataTransferObjects;

namespace uow_generic.AutoMapperConfigurationss
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMissingTypeMaps = true;
            CreateMap<Vehicle, VehicleDto>().ReverseMap();
        }
    }
}