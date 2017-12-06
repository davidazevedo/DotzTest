using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dotz.Data.MongoDb.Entities
{
    public class User : Entity<long>
    {
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("Document")]
        public string Document { get; set; }
        [BsonElement("TypeDocument")]
        public int TypeDocument { get; set; } 
    }
}
