using Dotz.Data.MongoDb.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Dotz.Data.MongoDb.Entities;
using MongoDB.Driver.Builders;

namespace Dotz.Data.MongoDb.Repository
{

    public class UserDotzRepository : RepositoryBase<UserDotz, long>
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Update(UserDotz entity, long id)
        {
            entity.Id = id;
            var res = Query<UserDotz>.EQ(pd => pd.Id, id);
            var operation = Update<UserDotz>.Replace(entity);
            _db.GetCollection<User>("UserDotz").Update(res, operation);
        }
    }
}
