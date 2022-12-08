﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace flowerbackend.Models
{
    public class Ultraviolet
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Value")]
        public double Value { get; set; }

        [BsonElement("Instance")]
        public int Instance{ get; set; }

        [BsonElement("Timestamp")]
        public string Timestamp { get; set; }

        [BsonElement("Status")]
        public string Status { get; set; }
    }
}
