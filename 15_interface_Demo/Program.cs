using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_interface_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new FileLogger();//Bunuda Çagırabilirsin
            customerManager.Logger = new DatabaseLogger(); //Bunuda Çagırabilirsin
            customerManager.Add();
            Console.ReadLine();
        }
        class CustomerManager
        {
            public Ilogger Logger { get; set; }
            public void Add()
            {
                Logger.Log();
                Console.WriteLine("Costomer Added !");
            }
        }
        interface Ilogger
        {
            void Log();
        }
        class Logger : Ilogger
        {
            public void Log()
            {
                Console.WriteLine("Logged");
            }
        }
        class FileLogger : Ilogger
        {
            public void Log()
            {
                Console.WriteLine("File Logged");
            }
        }
        class DatabaseLogger : Ilogger
        {
            public void Log()
            {
                Console.WriteLine("Database Logged");
            }
        }
        class SmsLogger : Ilogger
        {
            public void Log()
            {
                Console.WriteLine("Sms Logged");
            }
        }

    }
}
