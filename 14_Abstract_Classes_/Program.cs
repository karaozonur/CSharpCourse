using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Abstract_Classes_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer();
            database.Delete();
            database.Add();

            Console.ReadLine();
        }
        abstract class Database
        {
            public void Add()
            {
                Console.WriteLine("Added");
            }
            public abstract void Delete();
        }
        class SqlServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted Sql");
            }
        }
        class Oracle : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted Oracle");
            }
        }
    }
}
