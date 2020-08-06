using Fishy_Model.Models;
using System;
using System.Collections.Generic;

namespace Server.Data.Repositories
{
    public class FishRepository : IGenericRepository<FISH>
    {
        private FishyContext db;
        public FishRepository(FishyContext context)
        {
            db = context;
        }
        public void Create(FISH entity)
        {
            throw new NotImplementedException();
        }

        public FISH FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FISH> Get()
        {
            throw new NotImplementedException();
        }

        public void Remove(FISH entity)
        {
            throw new NotImplementedException();
        }

        public void Update(FISH entity)
        {
            throw new NotImplementedException();
        }
    }
}
