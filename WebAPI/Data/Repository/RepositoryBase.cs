using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Domain.Interface.Repository;

namespace WebAPI.Data.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
       where TEntity : class
    {
        private readonly AuthenticationContext _context;
        public RepositoryBase(AuthenticationContext context)
        {
            _context = context;
            _context.SaveChanges();
        }
        public virtual void Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public virtual TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
        public virtual IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }
        public virtual void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public virtual void Remove(TEntity obj)
        {
            obj.GetType().GetProperty("Ativo").SetValue(obj, false);
            Update(obj);
        }

        public virtual async Task SaveAsync(TEntity obj)
        {
            if (obj.GetType().GetProperty("Id").GetValue(obj) != null && obj.GetType().GetProperty("Id").GetValue(obj).ToString() != "0")
            {
                var entity = _context.Set<TEntity>().Find(obj.GetType().GetProperty("Id").GetValue(obj));

                if (entity != null)
                {
                    var entry = _context.Entry(entity);
                    entry.CurrentValues.SetValues(obj);
                }
            }
            else
            {
                _context.Set<TEntity>().Add(obj);
            }
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public virtual int Save(TEntity obj)
        {
            _context.SaveChanges();

            if (obj.GetType().GetProperty("Id").GetValue(obj) != null && obj.GetType().GetProperty("Id").GetValue(obj).ToString() != "0")
            {
                var entity = _context.Set<TEntity>().Find(obj.GetType().GetProperty("Id").GetValue(obj));

                if (entity != null)
                {
                    var entry = _context.Entry(entity);
                    entry.CurrentValues.SetValues(obj);
                }
            }
            else
            {
                _context.Set<TEntity>().Add(obj);
            }

            Stopwatch watch = new Stopwatch();
            watch.Start();
            var retorno = _context.SaveChanges();
            Task.Delay(5000);
            watch.Stop();

            return Convert.ToInt32(obj.GetType().GetProperty("Id").GetValue(obj));
        }

        public virtual async Task Delete(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}