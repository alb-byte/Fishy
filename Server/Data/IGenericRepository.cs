using System.Collections.Generic;

namespace Server.Data
{
    public interface IGenericRepository<TEntity> where TEntity:class
    {
        void Create(TEntity entity);
        TEntity FindById(int id);
        IEnumerable<TEntity> Get();
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
