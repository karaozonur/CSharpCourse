using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Attributes
{
    internal class Program
    {
        //Attributes -> Öznitellikler
        // Attributes araçılığı ile kurallar koyarsınız
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Onur";
            customer.LastName = "karöz";
            customer.Age = 27;
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
        [ToTable("Customer")]
        class Customer
        {
            public int Id { get; set; } 
            [RequiredProperty]
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
        class CustomerDal
        {
            public void Add(Customer customer)
            {
                Console.WriteLine("Aded",customer.Id,customer.FirstName);
            }
        }

        //////
        /// Attribute Oluşturma : Attribute sınıfından türetilmeli
        /// 
        // RequiredProperty Adını Biz belirledik
        // RequiredPropertyAttribute Attribute OLDUGUNU anlaması için belirlediğimiz adın sonuna Attribute ekledik.
        // :Attribute ilgili classı :Attributes  ile türettik
        class RequiredPropertyAttribute : Attribute
        {

        }
        // Attributes e parametre gönderilebilir  Constructors ile set edilir.
        class ToTableAttribute : Attribute
        {
            private string _tableName;
            public ToTableAttribute(string tableName)
            {
                this._tableName = tableName;
            }
        }

        //////
        /// 
        ////
        [AttributeUsage(AttributeTargets.All)]
        //AttributeTargets.All -> Bu attribute u herkese kullanabilirsin.
        class RequiredPropertyAttribute2 : Attribute
        {

        }

        //[AttributeUsage(AttributeTargets.Class)]
        // [AttributeUsage(AttributeTargets.Class)] -> Bu attribute sadece classlarda kullanabilirsin
        class Employee
        {
            public int Id { get; set; }
          
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }


        [AttributeUsage(AttributeTargets.Property)]
        class RequiredPropertyAttribute3 : Attribute
        {

        }

        // Birden fazla attribute taget kullanma

        //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Module)]

        // Birden fazla alanda attribute KULLANMAK İÇİN

        //[AttributeUsage(AttributeTargets.Property,AllowMultiple =true)]
    }
}
