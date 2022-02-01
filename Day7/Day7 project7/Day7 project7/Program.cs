using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_project7
{
    /*******************************************************
* Author: Bhanu Rama Krishna Prakash Jakkamsetti
* Purpose: create customer and product array
* *****************************************************/
    class Customer
    {
        public int id;
        public string name;
        public int age;

    }
    class Product
    {
        public int price;
        public string brand;
        public int quantity;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] e = new Customer[]
            {
                new Customer() { id = 1, name ="bhanu",age=10},
                new Customer() { id = 2, name = "rama", age = 15 },
                new Customer() { id = 3, name = "krishna", age = 20 },
                new Customer() { id = 4, name = "prakash", age = 25 },
        };
            //by using forloop
            for (int i = 0; i < e.Length; i++)
            {
                Console.WriteLine($"id={e[i].id} , name={e[i].name} , salary={e[i].age}");
            }
            //by using foreach loop
            foreach (var a in e)
            {
                Console.WriteLine($"id={a.id} , name={a.name} , salary={a.age}");
            }
            //by using lambda expression
            e.ToList().ForEach(a => Console.WriteLine($"id={a.id} , name={a.name} , salary={a.age}"));


            Product[] p = new Product[]
            {
                new Product() { price = 1000, brand ="puma",quantity=10},
                new Product() { price = 2000, brand = "nike", quantity = 15 },
                new Product() { price = 3000, brand = "roadster", quantity = 20 },
                new Product() { price = 4000, brand = "jill", quantity = 25 },
        };
            //by using forloop
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine($"id={p[i].price} , name={p[i].brand} , salary={p[i].quantity}");
            }
            //by using foreach loop
            foreach (var a in p)
            {
                Console.WriteLine($"id={a.price} , name={a.brand} , salary={a.quantity}");
            }
            //by using lambda expression
            p.ToList().ForEach(a => Console.WriteLine($"id={a.price} , name={a.brand} , salary={a.quantity}"));
        }

    }
}
