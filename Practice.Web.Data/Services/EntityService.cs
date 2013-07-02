using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Practice.Web.Data.Entities;

namespace Practice.Web.Data.Services
{
    public abstract class EntityService<T> :IEntityService<T>where T :IMongoEntity
    {
        protected EntityService()
        {
            MongoConnectionHandler = new MongoConnectionHandler<T>();
        }
        protected readonly MongoConnectionHandler<T> MongoConnectionHandler;
        public virtual void Create(T entity)
        {
            var result = MongoConnectionHandler.MongoCollection.Save(entity,
                                                                     new MongoInsertOptions
                                                                         {WriteConcern = WriteConcern.Acknowledged});
            if (!result.Ok)
            {
                Console.Write("Something Went wrong");
            }
        }
        public virtual void Delete(string id)
        {
            var result = MongoConnectionHandler.MongoCollection.Remove(Query<T>.EQ(e => e.Id ,new ObjectId(id)),
                                                                            RemoveFlags.None, WriteConcern.Acknowledged);
            if(!result.Ok){}
        }
        public virtual T GetId(string id)
        {
            var entityQuery = Query<T>.EQ(e => e.Id, new ObjectId(id));
            return MongoConnectionHandler.MongoCollection.FindOne(entityQuery);
        }
        public abstract void Update(T entity);
    }
}