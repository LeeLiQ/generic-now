using uow_generic.Core.IRepositories;

namespace uow_generic.Persistence.Repositories
{
    public class BaseRespository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        public TEntity Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<TEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Insert(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}