using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Server.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        DbContext context;
        DbSet<TEntity> dbSet;

        public GenericRepository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get()
        {
            return dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> GetEntities(Func<TEntity, bool> predicate)
        {
            return dbSet.AsNoTracking().Where(predicate).ToList();
        }
        public TEntity GetEntity(Func<TEntity, bool> predicate)
        {
            return dbSet.AsNoTracking().Where(predicate).FirstOrDefault();
        }
        public TEntity FindById(int id)
        {
            return dbSet.Find(id);
        }

        public void Create(TEntity item)
        {
            dbSet.Add(item);
        }
        public void Update(TEntity item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
        public void Remove(TEntity item)
        {
            dbSet.Remove(item);
        }
    }
}
