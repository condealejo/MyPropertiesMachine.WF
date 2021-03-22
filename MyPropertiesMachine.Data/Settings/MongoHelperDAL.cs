using MongoDB.Driver;
using MyPropertiesMachine.Entities;
using System;

namespace MyPropertiesMachine.Data
{
    public class MongoHelperDAL
    {
        public static IMongoClient clientMongo { get; set; }
        public static IMongoDatabase database { get; set; }
        public static string connectionString = Resources.DatabaseSettings.cnn;
        public static string mongoDatabase = Resources.DatabaseSettings.dbName;

        public static IMongoCollection<Machine> machineCollection { get; set; }

        internal static void ConnectToMongoService()
        {
            try
            {
                clientMongo = new MongoClient(connectionString);
                database = clientMongo.GetDatabase(mongoDatabase);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error conectando con BD." + ex.ToString());
            }
        }

    }
}
