using Fishy_Model.Models;
using System.Collections.Generic;

namespace Server.Data.Repositories
{
    public class MessageRepository : IGenericRepository<MESSAGE>
    {
        private FishyContext db;
        public MessageRepository(FishyContext context)
        {
            db = context;
        }
        public void Create(MESSAGE entity)
        {
            throw new System.NotImplementedException();
        }

        public MESSAGE FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<MESSAGE> Get()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(MESSAGE entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(MESSAGE entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
