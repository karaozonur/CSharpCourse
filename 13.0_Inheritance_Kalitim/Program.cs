using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._0_Inheritance_Kalitim
{
    internal class Program
    {
        //İnheritance KALITIM - MİRAS
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Onur";
            customer.Depetman = "Dd";

            Person[] persons = new Person[4]
                {
                new Customer{ Name= "ONUR",Depetman= "Visual"},
                new Student{ Name= "ONUR",Okul="asa"},
                new Person{ Name= "ONUR",Id=1234},
                new Deneme()
                };

            Console.ReadLine();
        }

        class Person
        {
            public string Name { get; set; }
            public int Id { get; set; }

        }
        class Customer : Person
        {
            public string Depetman { get; set; }
            public int Numara { get; set; }

        }
        class Student : Person
        {
            public string Okul { get; set; }
            public int OkulNumara { get; set; }

        }
        class Deneme : Person
        {

        }
    }
}
