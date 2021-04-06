using MongoDB.Bson.Serialization.Attributes;

namespace Chat.Domain.Models
{
    class UserModel : EntityBase
    {
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("password")]
        public int Password { get; set; }
    }
}
