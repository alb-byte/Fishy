using Fishy_Model.Models;
using System;
using System.Collections.Generic;

namespace Server.Data.Repositories
{
    public class FriendRepository : IGenericRepository<FRIEND>
    {
        private FishyContext db;
        public FriendRepository(FishyContext context)
        {
            db = context;
        }
        public void Create(FRIEND entity)
        {
            throw new NotImplementedException();
        }

        public FRIEND FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FRIEND> Get()
        {
            throw new NotImplementedException();
        }

        public void Remove(FRIEND entity)
        {
            throw new NotImplementedException();
        }

        public void Update(FRIEND entity)
        {
            throw new NotImplementedException();
        }
    }
}
