using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Application.Interface;
using WebAPI.Domain.Interface.Service;

namespace WebAPI.Application.Contrete
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _service;

        public AppServiceBase(IServiceBase<TEntity> service)
        {
            _service = service;
        }

        public void Add(TEntity obj)
        {
            _service.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _service.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _service.GetAll();
        }

        public void Update(TEntity obj)
        {
            _service.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _service.Remove(obj);
        }

        public virtual async Task SaveAsync(TEntity obj)
        {
            await _service.SaveAsync(obj);
        }

        public virtual int Save(TEntity obj)
        {
            try
            {
                return _service.Save(obj);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}