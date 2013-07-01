using MongoDB.Bson;
namespace Practice.Web.Data.Entities
{
    public interface IMongoEntity
    {
        ObjectId Id { get; set; }
    }
}
