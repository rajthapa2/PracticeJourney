using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Practice.Web.Data.Entities
{
    public class MongoEntity:IMongoEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}