using Fishy_Model.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Server.Data.Repositories
{
    public class CommentRepository : IGenericRepository<COMMENT>
    {
        private FishyContext db;
        public CommentRepository(FishyContext context)
        {
            db = context;
        }
        public void Create(COMMENT entity)
        {
            db.COMMENTS.Add(entity);
        }

        public COMMENT FindById(int id)
        {
            return db.COMMENTS.Find(id);
        }

        public IEnumerable<COMMENT> Get()
        {
            return db.COMMENTS.ToList();
        }

        public void Remove(COMMENT entity)
        {
            db.COMMENTS.Remove(entity);
        }

        public void Update(COMMENT entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
