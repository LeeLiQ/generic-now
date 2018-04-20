using System;
using System.Collections.Generic;
using uow_generic.Core;
using uow_generic.Core.Domains;
using uow_generic.Core.IRepositories;
using uow_generic.Persistence.Repositories;

namespace uow_generic.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Dictionary<Type, dynamic> _uow;

        public UnitOfWork()
        {
            _uow.Add(typeof(Vehicle), new VehicleRepository());
        }

        public void Complete()
        {
            throw new System.NotImplementedException();
        }

        public dynamic GetRepository<T>() where T : class
        {
            return _uow.TryGetValue(typeof(T), out dynamic repo);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitOfWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}