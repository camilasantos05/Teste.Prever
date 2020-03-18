using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        Task SaveAsync(TEntity obj);
        int Save(TEntity obj);
    }
}
