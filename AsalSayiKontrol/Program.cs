using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayiKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kendisi ve 1 Haricinde bölünemeyen sayıdır..
            if (isPrivateNumber(6))
            {
                Console.WriteLine("This is a private  number ");
            }
            else
            {
                Console.WriteLine("Not Private number");
            }
            Console.ReadLine();
        }
        private static bool isPrivateNumber(int number)
        {
            bool isPrivate = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    isPrivate = false;
                    i = number;

                }
            }
            return isPrivate;
        }
    }
}
