using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> list = utilities.BuildList<string>("Ankara","İzmir");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            List<Customer> customers = utilities.BuildList<Customer>(new Customer { name="Onur"}, new Customer(), new Customer());

            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        interface IRepository<T>
        {
            List<T> GetAll();
            T Get(int id);
            void Add(T item);   
            void Update(T item);
            void Delete(int id);
            void DeleteAll();      
        }
        interface ICustomerDal: IRepository<Customer>
        {

        }

        class Customer
        {
            public string name { get; set;}
        }
        class CustomerDal : ICustomerDal
        {
            public void Add(Customer item)
            {
                throw new NotImplementedException();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void DeleteAll()
            {
                throw new NotImplementedException();
            }

            public Customer Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Customer item)
            {
                throw new NotImplementedException();
            }
        }

        interface IProductDal : IRepository<Product>
        {

        }
        class Product
        {

        }
    
        class ProductDal : IProductDal
        {
            public void Add(Product item)
            {
                throw new NotImplementedException();
            }

            public void Delete(int id)
            {
                throw new NotImplementedException();
            }

            public void DeleteAll()
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Product item)
            {
                throw new NotImplementedException();
            }
        }


        ////////////////////
        ///////////// Generic Methodlar
        /////////////////
        class Utilities
        {
            public List<T> BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }
        }

        ////////////////////
        ///////////// Generic Kısıtları t yi kısıtlama
        /////////////////
        interface IStudentDal : IRepository2<Student> //buraya yazılan referans tip olmalı aynı zamanda newlene bilmeli string referanstır fakat int değil
        {

        }
        class Student
        {
            public string name { get; set; }
        }
        interface IRepository2<T> where T:class,new () //buraya yazılan referans tip olmalı aynı zamanda newlene bilmeli
        {
            List<T> GetAll();
            T Get(int id);
            void Add(T item);
            void Update(T item);
            void Delete(int id);
            void DeleteAll();
        }
        //,new () herzaman en sona koyulmalı
        interface IRepository3<T> where T : class, IEntity,new () // IEntity tarafından implente ediliyor kuralı
        {
            List<T> GetAll();
            T Get(int id);
            void Add(T item);
            void Update(T item);
            void Delete(int id);
            void DeleteAll();
        }
        interface IEntity
        {

        }
        class Employee: IEntity // Employee Classı IEntity interface i tarafından implente edilmiş
        {
            public string name { get; set; }
        }
        interface IEmployeeDal : IRepository3<Employee> 
        {

        }

    }
}
