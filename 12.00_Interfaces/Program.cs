using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._00_Interfaces
{
    internal class Program
    {
        // Büyük I ile Başlar
        // INTERFACELER NEW LENEMEZ
        static void Main(string[] args)
        {

            //PersonManager personManager = new PersonManager();
            //personManager.Add(new Customer { 
            //    Id = 1,
            //    Name ="Onur",
            //    LastName ="Karaöz",
            //    Type =1
            //});

            PersonManager personManager = new PersonManager();
            Customer Customer = new Customer
            {
                Id = 1,
                Name = "Onur",
                LastName = "Karaöz",
                Type = 1
            };
            personManager.Add(Customer);

            //Student StudentS = new Student
            //{
            //    Id = 1,
            //    Name = "Onur",
            //    LastName = "Karaöz",
            //    Depertment = "SAAD"
            //};
            //personManager.Add(StudentS); //Hata verir


            //INERFACE İLE TANIMLANMIŞ HALİ
            PersonManager2 personManager2 = new PersonManager2();

            Student student = new Student { LastName = "Karaöz", Id = 1, Name = "Dali", Depertment = "Yok" };
            personManager2.Add(student);


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());

            //ARRAY INTERFACE
            ICustomerDal[] customerDals = new ICustomerDal[2] {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }


        class PersonManager
        {
            public void Add(Customer customer)
            {
                Console.WriteLine(customer.Name);
            }
        }

        //INTERFACE 
        interface IPerson
        {
            //Soyut Nesne tek başına hiç bir şekilde bir anlam ifade etmez.
            int Id { get; set; }
            string Name { get; set; }
            string LastName { get; set; }
        }
        class Student : IPerson
        {
            //IPersone da tanımlanmış herşeyi burada görebiliriz.
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public string Depertment { get; set; }
        }
        class Customer : IPerson
        {
            //IPersone da tanımlanmış herşeyi burada görebiliriz.
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public byte Type { get; set; }

        }
        class PersonManager2
        {
            public void Add(IPerson customer)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}
