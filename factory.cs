using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Exercise_2
{
    public class Product
    {
        public string name { get; set; }
        public double price { get; set; }
    }
    public class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string Databasetype)
        {
            switch (Databasetype)
            {
                case "list":
                    return new ListDatabase();
                case "sql":
                    return new SqlDatabase();
                case "mongo":
                    return new MongoDatabase();
                default:
                    return null;
            }
        }
    }
}
