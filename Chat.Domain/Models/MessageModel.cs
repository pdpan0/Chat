using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Chat.Domain.Models
{
    class MessageModel
    {
        [BsonElement("message")]
        public string Message { get; set; }
        [BsonElement("send_at")]
        public DateTime SendAt { get; set; }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("send_by")]
        public string SendBy { get; set; }
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("chat_id")]
        public string ChatId { get; set; }
    }
}
