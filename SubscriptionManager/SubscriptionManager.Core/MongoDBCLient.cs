using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionManager.Core
{
    public class MongoDBCLient
    {
        private static IMongoDatabase _database;
        private static MongoDBCLient _instance;

        public static MongoDBCLient Instance
        {
            get => _instance ?? new MongoDBCLient();
        }

        public MongoDBCLient()
        {
            var conectionString = "mongodb+srv://bashuk0325oleksij_db_user:lZHXFstos2k8lAMX@data.t7bzerb.mongodb.net/?retryWrites=true&w=majority&appName=Data";
            var client = new MongoClient(conectionString);
            _database = client.GetDatabase("Elements");
        }

        public IMongoCollection<T> GetCollection<T>(string name) => _database.GetCollection<T>(name);
    }
}
