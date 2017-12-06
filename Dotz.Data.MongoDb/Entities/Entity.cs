using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dotz.Data.MongoDb.Entities
{
    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        [BsonElement("Id")]
        public virtual TPrimaryKey Id { get; set; }

        public bool IsTransient()
        {
            return false;
        }
    }

}
