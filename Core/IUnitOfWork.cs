using uow_generic.Core.IRepositories;

namespace uow_generic.Core
{
    public interface IUnitOfWork
    {
        IVehicleRepository _vehicleRepository { get; }

        void Complete();
    }
}