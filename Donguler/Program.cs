using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        //LOOP - DÖNGÜ 
        //FOR - İÇİN
        //WHİLE- SÜRE ZAMAN WAKİT
        //DO WHILE - YAPARKEN
        //FOREACH - HERBİRİ İÇİN
        static void Main(string[] args)
        {
            FORLoop();
            WHILE_LOOP(); 
            DO_WHILE_LOOP();
            FOREACH_LOOP();
            Console.ReadLine();
        }
        static void FORLoop()
        {
            //1 Den başlayıp tüm sayıları yazdırma
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");


            //1 Den başlayıp TEK sayıları yazdırma
            for (int i = 1; i <= 100; i += 2) //İ=İ+2
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");

            //ÇİFT sayıları yazdırma 1
            for (int i = 0; i <= 100; i += 2) //İ=İ+2
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");

            //ÇİFT sayıları yazdırma 2
            for (int i = 2; i <= 100; i += 2) //İ=İ+2
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");

            //100 DEN BAŞLATIP GERİ GERİ YAZDIRMA
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");

            //100 DEN BAŞLATIP GERİ GERİ YAZDIRMA  -- ÇİFT SAYILAR
            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");

            // 100 DEN BAŞLATIP GERİ GERİ YAZDIRMA-- TEK SAYILAR
            for (int i = 99; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");

        }
        static void WHILE_LOOP()
        {
            //Belirli bir şart sağlanana kadar döngü çalışmaya devam eder.
            int number = 100;
            while (number>=0)
            {
                Console.WriteLine(number);  
                number--; // Bunu kullanmazsan sonsuz döngü olur.
            }
            Console.WriteLine("Now number is {0}",number);
            Console.ReadLine();
        }
        static void DO_WHILE_LOOP()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
                //Şart sağlanmasa bile şart 1 kere çalışır.
            } while (number>=0);
            Console.ReadLine();
        }
        static void FOREACH_LOOP()
        {
            string[] students = new string[4];

           
            students[0] = "Onur";
            students[1] = "Karaoz";
            students[2] = "2243";

            foreach (var stList in students)
            {
                Console.WriteLine(stList);
            }
            Console.ReadLine();
        }
    }
}
