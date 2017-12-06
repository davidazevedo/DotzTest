using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dotz.Data.MongoDb.Entities
{
    public class UserDotz : Entity<long> {
        [BsonElement("TotalsDotz")]
        public long TotalsDotz { get; set; }
        [BsonElement("User")]
        public long UserId { get; set; }
    }

}
