using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ArrayDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //DİZİ TANIMLAMA 1
            string[] students = new string[4];

            //DİZİ DEĞERVERME
            students[0] = "Onur";
            students[1] = "Karaoz";
            students[2] = "2243";

            foreach (var stList in students)
            {
                Console.WriteLine(stList);
            }

            //DİZİ TANIMLAMA VE DEĞER VERME
            int[] numbers = new int[4] { 1453, 1234, 2345, 0 };

            foreach (var stList in numbers)
            {
                Console.WriteLine(stList);
            }

            ////////////////////////////
            //ÇOK BOYUTLU DİZİ TANIMLAMA
            ////////////////////////////
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","Edirne","Balıkesir"},
                {"Ankara","Konya","Isparta"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"},
            };
            //7 Satır 
            //3 Sütun
            for (int i = 0; i <= regions.GetUpperBound(0); i++) //Satırları Gezdim
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("---------------");
            }


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
