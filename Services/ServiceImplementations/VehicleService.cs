using uow_generic.Core.Domains;
using uow_generic.DataTransferObjects;
using uow_generic.Services.Interfaces;

namespace uow_generic.Services.ServiceImplementations
{
    public class VehicleService : BaseService<Vehicle, VehicleDto>, IVehicleService
    {
        public VehicleDto GetByVin(string vinNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}