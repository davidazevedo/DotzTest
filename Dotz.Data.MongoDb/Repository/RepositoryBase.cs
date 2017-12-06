using Dotz.Data.MongoDb.Entities;
using Dotz.Data.MongoDb.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Collections.Generic;

namespace Dotz.Data.MongoDb.Repository
{
    public class RepositoryBase<TEntity, TPrimaryKey> : DotzBaseRepository, IRepositoryBase<TEntity, TPrimaryKey>
    {
        public RepositoryBase()
            : base()
        {
        }

        public TEntity Create(TEntity entity)
        {
            _db.GetCollection<TEntity>(entity.GetType().ToString()).Save(entity);
            return entity;
        }

    }
}
