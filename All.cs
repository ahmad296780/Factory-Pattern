using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Exercise_2
{
    public interface IDataAccess
    {
        List<Product> LoadData();
        void SaveData();
    }
    public class ListDatabase : IDataAccess
    {
        public static List<Product> products = new List<Product>()
        {
            new Product {name = "Laptop", price = 22},
            new Product {name = "pen", price = 2}
        };


        public List<Product> LoadData()
        {
            Console.WriteLine("I AM READING DATA FROM LIST CLASS");
            return products;
        }
        public void SaveData()
        {
            Console.WriteLine("I AM SAVING DATA FROM LIST CLASS");
        }
    }
    public class SqlDatabase : IDataAccess
    {
        public static List<Product> products = new List<Product>()
        {
            new Product {name = "Laptop", price = 22},
            new Product {name = "pen", price = 2}
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I AM READING DATA FROM SQL");
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("I AM SAVING DATA OF SQL");
        }
    }
    public class MongoDatabase : IDataAccess
    {
        public static List<Product> products = new List<Product>()
        {
            new Product {name = "Laptop", price = 22},
            new Product {name = "pen", price = 2}
        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I AM READING DATA OF MONGO");
            return products;
        }

        public void SaveData()
        {
            Console.WriteLine("I AM SAVING DATA OF MONGO");
        }
    }
}
