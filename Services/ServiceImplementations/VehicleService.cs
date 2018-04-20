using AutoMapper;
using uow_generic.Core;
using uow_generic.Core.Domains;
using uow_generic.DataTransferObjects;
using uow_generic.Persistence.Repositories;
using uow_generic.Services.Interfaces;

namespace uow_generic.Services.ServiceImplementations
{
    public class VehicleService : BaseService<Vehicle, VehicleDto>, IVehicleService
    {
        public VehicleService(IUnitOfWork uow)
            : base(uow)
        { }
        public VehicleDto GetByVin(string vinNumber)
        {
            return Mapper.Map<VehicleDto>(_uow.GetRepository<Vehicle>().GetByVin(vinNumber));
        }
    }
}