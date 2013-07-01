using MongoDB.Driver;
using Practice.Web.Data.Entities;

namespace Practice.Web.Data
{
    public class MongoConnectionHandler<T> where T: IMongoEntity
    {
        public MongoCollection<T> MongoCollection { get; private set; }

        public MongoConnectionHandler()
        {
            const string connectionString = "mongodb://localhost";

            //Get a thread- sage client object using a connection string
            var mongoClient = new MongoClient(connectionString);
            //Get a reference to a server object from the Mongo Client object
            var mongoServer = mongoClient.GetServer();
            //Get a reference to the "practiceweb" database object from the mongo server object
            const string databaseName = "practiceWeb";
            var db = mongoServer.GetDatabase(databaseName);
            //Get a reference to the collection object from the Mongo database onject
            //The collection name is the type converted to lowercase "s"
            MongoCollection = db.GetCollection<T>(typeof (T).Name.ToLower() + "s");
        }
    
    
    
    
    }
}
