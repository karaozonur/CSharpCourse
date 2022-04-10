using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethod
{
    internal class Program
    {
        // Sentence --> Cümle
        // Length --> Uzunluk
        // Clone --> Klon - Eşeysiz Çoğaltma
        // EndsWith --> ile Biter
        // StartsWith --> İle başlar
        // indexOf --> indeksi
        // LastIndexOf -->Son indeksi
        // Insert --> Eklemek
        // Substring
        // ToLower --> daha düşük
        // ToUpper --> daha yüksek - Yukarıya
        // Replace --> Yer değiştirmek
        // Remove --> Kaldırmak
        static void Main(string[] args)
        {
            string sentence = "My name is Lord Voldemort";
            /////////////////////////////////////////
            //CÜMLENİN KAÇ KARAKTERDEN OLUŞTUĞUNU VERİR. BOŞLUKLARIDA SAYAR
            /////////////////////////////////////////
            Console.WriteLine("----Length----");

            var result = sentence.Length;
            Console.WriteLine(result);
            Console.WriteLine("---------------");
            /////////////////////////////////////////
            //Clone --> klonlar
            /////////////////////////////////////////
            Console.WriteLine("----Clone----");

            var result2 = sentence.Clone();
            Console.WriteLine(result2);
            Console.WriteLine("---------------");
            /////////////////////////////////////////
            //EndsWith --> t ile bitiyor mu? Sonuç True/False çeklinde döndürülür.
            /////////////////////////////////////////
            Console.WriteLine("----EndsWith----");

            bool EndsWith = sentence.EndsWith("t"); // Sonuç True
            Console.WriteLine(EndsWith);
            Console.WriteLine("---------------");
            /////////////////////////////////////////
            //StartsWith --> My name ile başlıyor mu? Sonuç True/False çeklinde döndürülür.
            /////////////////////////////////////////
            Console.WriteLine("----StartsWith----");

            bool StartsWith = sentence.StartsWith("My name"); // Sonuç True
            Console.WriteLine(StartsWith);
            Console.WriteLine("---------------");
            /////////////////////////////////////////
            //IndexOf -->Cümle içinde belirli bir karakter ve ifadeyi aramak için kullanılır. Kaçıncı karakterde başladığını belli eder.    
            /////////////////////////////////////////
            Console.WriteLine("----IndexOf----");

            var IndexOf = sentence.IndexOf("name"); // Sonuç 3
            Console.WriteLine(IndexOf);
            //Bulamadığında -1 Döndürür
            var IndexOf2 = sentence.IndexOf("name3"); // Sonuç -1
            Console.WriteLine(IndexOf2);
            //Buşduğu ilk boşluğun veya karakterin değerini verir.
            var IndexOf3 = sentence.IndexOf(" "); // Sonuç -1
            Console.WriteLine(IndexOf3);
            Console.WriteLine("---------------");
            /////////////////////////////////////////
            //LastIndexOf -->ARAMAYA SONDAN BAŞLAR - Cümle içinde belirli bir karakter ve ifadeyi aramak için kullanılır. Kaçıncı karakterde başladığını belli eder.    
            /////////////////////////////////////////
            Console.WriteLine("----LastIndexOf----");
            var LastIndexOf = sentence.LastIndexOf("name"); // Sonuç 3
            Console.WriteLine(LastIndexOf);
            //Bulamadığında -1 Döndürür
            var LastIndexOf2 = sentence.LastIndexOf("name3"); // Sonuç -1
            Console.WriteLine(LastIndexOf2);
            //Buşduğu ilk boşluğun veya karakterin değerini verir.
            var LastIndexOf3 = sentence.LastIndexOf(" "); // Sonuç -1
            Console.WriteLine(LastIndexOf3);
            Console.WriteLine("---------------");

            /////////////////////////////////////////
            //Insert --> Bir cümleye başka bir kelime cümle yerleştirmek için kullanılır.
            /////////////////////////////////////////
            Console.WriteLine("----Insert----");
            var Insert = sentence.Insert(0,"Hello, "); // 0'ıncı karakter itibariyle başına hello ekler -- Hello,  My name is Lord Voldemort
            Console.WriteLine(Insert);
            Console.WriteLine("---------------");
            /////////////////////////////////////////
            //Substring --> Metni parçalamak için kullanılır.s
            /////////////////////////////////////////
            Console.WriteLine("----Substring----");
            var Substring = sentence.Substring(3); // --> name is Lord Voldemort
            Console.WriteLine(Substring);
            var Substring2 = sentence.Substring(3,7); // --> name is
            Console.WriteLine(Substring2);
            Console.WriteLine("---------------");
            /////////////////////////////////////////
            //ToLower --> Bütün karakterleri küçük harfe çevirir
            /////////////////////////////////////////
            Console.WriteLine("----ToLower----");
            var ToLower = sentence.ToLower(); //
            Console.WriteLine(ToLower);
            Console.WriteLine("---------------");
            /////////////////////////////////////////
            //ToUpper --> Bütün karakterleri büyük harfe çevirir
            /////////////////////////////////////////
            Console.WriteLine("----ToUpper----");
            var ToUpper = sentence.ToUpper(); //
            Console.WriteLine(ToUpper);
            Console.WriteLine("---------------");
            /////////////////////////////////////////
            //Replace --> belirtilen karakterleri değiştirir.
            /////////////////////////////////////////
            Console.WriteLine("----Replace----");
            var Replace = sentence.Replace(" ","-"); // boşluk karakterini çizgi ile değiştiriyor. My-name-is-Lord-Voldemort
            Console.WriteLine(Replace);
            Console.WriteLine("---------------");
            /////////////////////////////////////////
            //Replace --> belirtilen karakterleri değiştirir.
            /////////////////////////////////////////
            Console.WriteLine("----Remove----");
            var Remove = sentence.Remove(2); // İkinci karakterden sonrasını kaldırır.
            Console.WriteLine(Remove);
            var Remove2 = sentence.Remove(2,5); // İkinci karakterden sonra 4 e kadar kaldırır.
            Console.WriteLine(Remove2);
            Console.WriteLine("---------------");

            Console.ReadLine();
        }
    }
}
