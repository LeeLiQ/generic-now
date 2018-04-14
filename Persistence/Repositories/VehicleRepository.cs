using uow_generic.Core.Domains;
using uow_generic.Core.IRepositories;
using uow_generic.DataTransferObjects;

namespace uow_generic.Persistence.Repositories
{
    public class VehicleRepository : BaseRespository<Vehicle>, IVehicleRepository
    {
        public Vehicle GetByVin(string vinNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}