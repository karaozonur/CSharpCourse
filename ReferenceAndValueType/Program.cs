using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    { 
        //18. Ders Değer ve referans tiplerini 
        //Reference And Value Type
        static void Main(string[] args)
        {
            int number1 = 10; // Değer Tip
            int number2 = 20; // Değer Tip
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            //Refrans Tipler Class Array Abstrack classlar

            string[] cities1 = new string[] { "Ankara","Adana","Afyon"};
            string[] cities2 = new string[] { "Muğla", "Antalya", "Maraş" };
            cities2= cities1; //cities1 deki tüm değerler uçtu

            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);



            Console.ReadLine();
        }
    }
}
