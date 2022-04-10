using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sql= new SqlServer();
            sql.Add();
            mySqlServer my=new mySqlServer();
            my.Add();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }
    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added");
            //base.Add();
            //{
            //    Console.WriteLine();
            //}
        }
    }
    class mySqlServer : Database
    {

    }
}
