using uow_generic.Core.IRepositories;

namespace uow_generic.Persistence.Repositories
{
    public class BaseRespository<TEntity, TDto> : IRepository<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        public TEntity Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<TDto> GetAll()
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