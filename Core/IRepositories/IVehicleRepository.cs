using uow_generic.Core.Domains;

namespace uow_generic.Core.IRepositories
{
    public interface IVehicleRepository
    {
        Vehicle GetByVin(string vinNumber);
    }
}