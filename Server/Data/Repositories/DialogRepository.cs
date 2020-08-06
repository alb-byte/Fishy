using Fishy_Model.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Server.Data.Repositories
{
    public class DialogRepository : IGenericRepository<DIALOG>
    {
        private FishyContext db;
        public DialogRepository(FishyContext context)
        {
            db = context;
        }
        public void Create(DIALOG entity)
        {
            db.DIALOGS.Add(entity);
        }

        public DIALOG FindById(int id)
        {
            return db.DIALOGS.Find(id);
        }

        public IEnumerable<DIALOG> Get()
        {
            return db.DIALOGS.ToList();
        }

        public void Remove(DIALOG entity)
        {
            db.DIALOGS.Remove(entity);
        }

        public void Update(DIALOG entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
