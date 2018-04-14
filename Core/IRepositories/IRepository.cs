using System.Collections.Generic;

namespace uow_generic.Core.IRepositories
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        TEntity Insert(TEntity entity);

        TEntity Update(TEntity entity);

        TEntity Delete(int id);
    }
}