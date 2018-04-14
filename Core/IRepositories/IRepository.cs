using System.Collections.Generic;

namespace uow_generic.Core.IRepositories
{
    public interface IRepository<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        TDto GetById(int id);

        IEnumerable<TDto> GetAll();

        TEntity Insert(TDto entity);

        TEntity Update(TEntity entity);

        TEntity Delete(int id);
    }
}