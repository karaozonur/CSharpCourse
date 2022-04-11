﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        //Private -> Tanımlandığı blok içinde geçerli
        //Protected -> Private tüm özelliklerini kapsar INHERİT EDİLDİĞİ Student: Customer SINIFLARDA KULLANILIR
        //İnternal -> Proje içinde istediğimiz noktada çagıra bilirsiniz
        //İnternal -> Classlar sadece internal veya public olur
        // Public 

        static void Main(string[] args)
        {
        }
        class Customer
        {
            protected int OD { get; set; }    
            private int id2;
            public void Delete()
            {

            }
            protected void Saprotected()
            {

            }
            int id;
        }
        class Student: Customer
        {
            
            public void Save()
            {
                OD = 0; //protected : Customer dan inherit edilmiş
                        // id2 // Hata verir private
                Delete();//public
                Saprotected(); //protected Metot: Customer dan inherit edilmiş
            }
        }
       internal class Course // 
        {
            public string Name { get; set; }
        }
    }
}
