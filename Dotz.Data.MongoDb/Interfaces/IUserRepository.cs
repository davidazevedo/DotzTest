using Dotz.Data.MongoDb.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Data.MongoDb.Interfaces
{
    public interface IUserRepository : IRepositoryBase<UserDotz, long>
    {
        IEnumerable<UserDotz> List();
        UserDotz GetByID(long id);
        void Update(UserDotz entity, long id);
        void Remove(UserDotz id);
    }
}
