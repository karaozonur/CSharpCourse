using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Constructors_Yapici_Bloklar
{
    internal class Program
    {
        //Constructors - Yapıcılar > Class Newlendiğinde çalışacak kod bloğu
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();


            Product product = new Product { ID = 1, Name = "Easy Eye" };
            //Constructors
            Product product1 = new Product(2, "Computer");


            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());


            PersonelManager personelManager = new PersonelManager("Product");
            personelManager.Add();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count;
        //Constructors 1
        public CustomerManager(int count)
        {
            _count = count;
        }
        //Constructors 2
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        //Constructors 1
        public Product()
        {

        }
        private int _id;
        string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public string Name { get; set; }
        public int ID { get; set; }
    }
    /// <summary>
    /// 17.3 Constructor Injection Interfaces
    /// </summary>
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log Database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log File");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        //Constructors
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            Console.WriteLine("Add");
        }
    }

    // 17.4 Constructors  - Parametre Gönderme
    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Massage()
        {
            Console.WriteLine("Message", _entity);
        }
    }
    class PersonelManager : BaseClass
    {
        public PersonelManager(string entity) : base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Message Add");
            Massage();
        }
    }
}
