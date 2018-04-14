using uow_generic.Core;
using uow_generic.Core.IRepositories;

namespace uow_generic.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public IVehicleRepository _vehicleRepository { get; private set; }

        public void Complete()
        {
            throw new System.NotImplementedException();
        }
    }
}