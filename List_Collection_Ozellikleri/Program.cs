using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Collection_Ozellikleri
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers2 = new List<Customer>
            {
                new Customer {ID=1,Name="Onur" },
                new Customer { ID = 2, Name = "Karaçz" }
            };
            // Listteki Eleman Sayısı
            var count = customers2.Count; 
          
            // Yeni Eleman Ekleme  1
            customers2.Add(new Customer { ID = 3, Name = "Ali" });

            // Yeni Eleman Ekleme 2
            var customer = new Customer {
                ID = 4, Name = "Salih"
            };
            customers2.Add(customer);

            // Dizi Arrayı Liste Eklemek
            customers2.AddRange(new Customer[2] 
                {
                    new Customer{ID=6,Name="ASDA"},
                    new Customer{ID=7,Name="ASDA"},
                });

            // List Temizleme
            customers2.Clear();

            // Aradığımız değer var mı? True False Döner
            customers2.Contains(new Customer { ID = 7, Name = "ASDA" }); // False Döner New dediğin için yeni bir referans demek
            var customer2 = new Customer
            {
                ID = 4,
                Name = "Salih"
            };
            customers2.Add(customer2);
            customers2.Contains(customer2); // True Döner

            //Listede elemanın kaçıncı sırada oldugunu
            var indexOf= customers2.IndexOf(customer2);
            Console.WriteLine(indexOf);

            //Listede elemanın kaçıncı sondan sırada oldugunu
            var LastIndexOf = customers2.LastIndexOf(customer2);
            Console.WriteLine(LastIndexOf);

            //Kaçıncı Sıraya ne ekliyosun ADD Listenin en sonuna ekler
            customers2.Insert(0,customer2);
            //Buldugu ilk değeri uçurur bulduğu anda hiç bişey yapmaz
            customers2.Remove(customer2);
            //Aradıklarını Tamamen siler
            customers2.RemoveAll(x=>x.Name=="Onur"); 


            foreach (var item in customers2)
            {
                Console.WriteLine(item.Name);
            }

        }

    }
    class Customer
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
}
