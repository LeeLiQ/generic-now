using uow_generic.DataTransferObjects;

namespace uow_generic.Services.Interfaces
{
    public interface IVehicleService
    {
        VehicleDto GetByVin(string vinNumber);
    }
}