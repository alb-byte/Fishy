using Fishy_Model.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Server.Data.Repositories
{
    public class AlbumRepository : IGenericRepository<ALBUM>
    {
        private FishyContext db;
        public AlbumRepository(FishyContext context)
        {
            db = context;
        }
        public void Create(ALBUM entity)
        {
            db.ALBUMS.Add(entity);
        }

        public ALBUM FindById(int id)
        {
            return db.ALBUMS.Find(id);
        }

        public IEnumerable<ALBUM> Get()
        {
            return db.ALBUMS.ToList();
        }

        public void Remove(ALBUM entity)
        {
            db.ALBUMS.Remove(entity);
        }

        public void Update(ALBUM entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
