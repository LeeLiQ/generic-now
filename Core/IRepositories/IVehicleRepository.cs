using uow_generic.Core.Domains;

namespace uow_generic.Core.IRepositories
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        Vehicle GetByVin(string vinNumber);
    }
}