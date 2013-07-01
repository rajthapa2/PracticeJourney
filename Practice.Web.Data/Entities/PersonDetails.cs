using MongoDB.Bson.Serialization.Attributes;

namespace Practice.Web.Data.Entities
{
    [BsonIgnoreExtraElements]
    public class PersonDetails:MongoEntity
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string MaritalStatus { get; set; }
    }
}