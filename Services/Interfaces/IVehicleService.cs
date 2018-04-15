using uow_generic.Core.Domains;
using uow_generic.DataTransferObjects;

namespace uow_generic.Services.Interfaces
{
    public interface IVehicleService : IService<Vehicle, VehicleDto>
    {
        VehicleDto GetByVin(string vinNumber);
    }
}