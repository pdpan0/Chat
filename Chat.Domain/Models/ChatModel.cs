using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Chat.Domain.Models
{
    class ChatModel : EntityBase
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("user_id")]
        public string UserId { get; set; }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("doctor_id")]
        public string DoctorId { get; set; }
    }
}
