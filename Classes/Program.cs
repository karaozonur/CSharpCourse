using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        //Class lar içinde değerde tutulur. PROPERTY
        //Classlar sadece internal veya public olur. private veya Protected olamaz
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            Console.WriteLine("----------------");
            ProductManager productManager = new ProductManager();   
            productManager.Add();
            productManager.Update();

            Console.WriteLine("----Farklı Class Dosyasında---");
            CManager cManager = new CManager();
            cManager.Add();
            cManager.Update();
            Console.WriteLine("----------------");

            //Class Dosyasında tanımlanan PROPERTY alanlarına değer vermek.
            tbCustomer tbCustomer=new tbCustomer();
            tbCustomer.ID = 1; //SET
            tbCustomer.Name = "Onur";  //SET
            tbCustomer.City = "Muğla"; //SET
            Console.WriteLine(tbCustomer.City); //GET

            tbCustomer tbCustomer2 = new tbCustomer
            {
                ID = 2,Name="karaoz",City= "marmaris"  //SET
            };

            Console.WriteLine(tbCustomer2.City);  //GET


            Console.ReadLine();

           
        }
    }
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added..");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated..");
        }

    }
    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added..");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated..");
        }

    }
}
