using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Data.MongoDb.Interfaces
{
    public interface IRepositoryBase<TEntity, TPrimaryKey> 
    {
        TEntity Create(TEntity p);
    }
}
