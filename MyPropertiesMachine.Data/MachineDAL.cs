using MongoDB.Driver;
using MyPropertiesMachine.Entities;
using System;
using System.Collections.Generic;

namespace MyPropertiesMachine.Data
{
    public class MachineDAL
    {
        private static Random random = new Random();
        public bool InsertMachineProperties(Machine prmMachine)
        {
            bool resultMachineInsert = false;
            try
            {
                MongoHelperDAL.ConnectToMongoService();
                MongoHelperDAL.machineCollection = MongoHelperDAL.database.GetCollection<Machine>("MachineProperties");
                MongoHelperDAL.machineCollection.InsertOneAsync(prmMachine);
                resultMachineInsert = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error insertando propiedades: " + ex.ToString());
            }
            return resultMachineInsert;
        }

        public List<Machine> GetMachinePropertiesByIP(string prmIPAddress)
        {
            List<Machine> listMachineProperties = new List<Machine>();
            try
            {
                MongoHelperDAL.ConnectToMongoService();
                MongoHelperDAL.machineCollection = MongoHelperDAL.database.GetCollection<Machine>("MachineProperties");
                var filter = Builders<Machine>.Filter.Ne("Ip", "");
                listMachineProperties = MongoHelperDAL.machineCollection.Find(filter).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error insertando propiedades: " + ex.ToString());
            }
            return listMachineProperties;
        }

    }
}
