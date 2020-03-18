using System;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Domain.Interface.Repository;
using WebAPI.Domain.Interface.Service;

namespace WebAPI.Domain.Service
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }
        public virtual void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public virtual TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
        public virtual void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
        public virtual void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }
        public virtual async Task SaveAsync(TEntity obj)
        {
            await _repository.SaveAsync(obj);
        }
        public virtual async Task Delete(TEntity obj)
        {
            await _repository.Delete(obj);
        }
        public virtual int Save(TEntity obj)
        {
            try
            {
                return _repository.Save(obj);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}