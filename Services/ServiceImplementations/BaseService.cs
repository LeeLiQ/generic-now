using uow_generic.Services.Interfaces;
using System.Collections.Generic;
using uow_generic.Core;
using AutoMapper;

namespace uow_generic.Services.ServiceImplementations
{
    public class BaseService<TEntity, TDto> : IService<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        private readonly IUnitOfWork _uow;
        public BaseService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public TEntity Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TDto> GetAll()
        {
            return Mapper.Map<IEnumerable<TDto>>(_uow.GetRepository<TEntity>().GetAll());
        }

        public TDto GetById(int id)
        {
            return Mapper.Map<TDto>(_uow.GetRepository<TEntity>().GetById(id));
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