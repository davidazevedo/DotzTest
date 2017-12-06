using Dotz.Data.MongoDb.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Dotz.Data.MongoDb.Entities;
using MongoDB.Driver.Builders;

namespace Dotz.Data.MongoDb.Repository
{
    public class UserRepository : RepositoryBase<User, long>
    {

        public User GetByID(long id)
        {
            var res = Query<User>.EQ(p => p.Id, id);
            return _db.GetCollection<User>("User").FindOne(res);
        }

        public IEnumerable<User> List()
        {
            return _db.GetCollection<User>("User").FindAll();
        }

        public void Remove(User user)
        {
            var res = Query<User>.EQ(e => e.Id, user.Id);
            var operation = _db.GetCollection<User>("User").Remove(res);
        }

        public void Update(User entity, long id)
        {
            entity.Id = id;
            var res = Query<User>.EQ(pd => pd.Id, id);
            var operation = Update<User>.Replace(entity);
            _db.GetCollection<User>("User").Update(res, operation);
        }


    }
}
