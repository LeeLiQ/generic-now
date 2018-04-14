using uow_generic.Services.Interfaces;
using System.Collections.Generic;

namespace uow_generic.Services.ServiceImplementations
{
    public class BaseService<TEntity, TDto> : IService<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        public TEntity Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TDto> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public TDto GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Insert(TDto entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}