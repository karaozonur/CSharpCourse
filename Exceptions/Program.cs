
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<string> std = new List<string> { "Engin", "Derin", "Salih" };
                if (!std.Contains("Ahmet"))
                {
                    throw new Properties.RecordNotFoundException("Record Not Found");
                }
                else
                {
                    Console.WriteLine("Record Found");
                }
            }
            catch (Properties.RecordNotFoundException ex)
            {

                Console.WriteLine("Record Found", ex.Message);
            }


            try
            {
                //Kodlar
            }
            catch (IndexOutOfRangeException exp)
            {
                Console.WriteLine("Exception", exp.Message);
                throw;
            }
            catch (DivideByZeroException exp)
            {
                Console.WriteLine("Exception", exp.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception", e.Message);
                throw;
            }
        }
    }
}
