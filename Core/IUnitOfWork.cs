using System;
using uow_generic.Core.IRepositories;

namespace uow_generic.Core
{
    public interface IUnitOfWork : IDisposable
    {
        void Complete();

        dynamic GetRepository<T>() where T : class;
    }
}