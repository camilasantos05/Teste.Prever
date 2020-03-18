using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Domain.Interface.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        Task<TEntity> GetByIdAsync(int id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        Task SaveAsync(TEntity obj);
        Task Delete(TEntity obj);
        int Save(TEntity obj);
    }
}