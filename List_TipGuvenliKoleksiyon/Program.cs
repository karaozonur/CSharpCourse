using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_TipGuvenliKoleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer {ID=1,Name="Onur" });
            customers.Add(new Customer { ID = 2, Name = "Karaçz" });
            foreach (var item in customers)
            {
                Console.WriteLine(item.Name);
            }

            List<Customer> customers2 = new List<Customer>
            {
                new Customer {ID=1,Name="Onur" },
                new Customer { ID = 2, Name = "Karaçz" }
            };
            foreach (var item in customers2)
            {
                Console.WriteLine(item.Name);
            }


            Console.ReadLine();
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
}
