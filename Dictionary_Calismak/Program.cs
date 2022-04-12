using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Calismak
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Dicti = new Dictionary<string, string>();
            Dicti.Add("A","B");
            Dicti.Add("B", "C");

            Dictionary<int, string> Dicti2 = new Dictionary<int, string>();
            Dicti2.Add(1, "B");
            Dicti2.Add(2, "C");

            //DEĞER ARAMA - DEĞER YOKSA HATA VERİRS
            var st= Dicti["A"];
            Console.WriteLine(st);

            foreach (var item in Dicti)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

           var count= Dicti.Count();

            //SENDE A İFADESİ VARMI TRUE FALSE DÖNDÜRÜR
           var tfalse= Dicti.ContainsKey("A");
            Console.WriteLine(tfalse);
        }
    }
}
