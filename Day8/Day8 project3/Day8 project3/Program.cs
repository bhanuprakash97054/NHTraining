using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_project3
{

    /*******************************************************************************
 * Author:Bhanu Rama Krishna Prakash Jakkamsetti
 * Purpose:create list of product
 * *************************************/
    class Product
    {
        public int id;
        public string name;
        public int price;
        public string brand;

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Product> data = new List<Product>()
            {
               new Product() { id = 1, name ="bhanu",price =450,brand="puma"},
                new Product() { id = 2, name = "rama", price = 600,brand="nike" },
                 new Product() { id = 3, name = "krishna", price = 400,brand="reebok"},
                  new Product() { id = 4, name = "prakash", price = 800,brand="indianterrain" },
                   new Product() { id = 5, name = "jakkamsetti", price = 300,brand="LOL" }
            };

            //by using forloop
            Console.WriteLine("for loop");
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].price > 500)
                {
                    Console.WriteLine($"name={data[i].name}, brand={data[i].brand}");
                }
            }
            //by using foreach loop
            Console.WriteLine("foreach loop");
            foreach (var d in data)
            {
                if (d.price > 500)
                {
                    Console.WriteLine($"name={d.name}, brand={d.brand}");
                }
            }
            //by using lambda expression
            Console.WriteLine("lambda");
            data.Where(d => d.price > 500).ToList().ForEach(d => Console.WriteLine($"name={d.name}, brand={d.brand}"));
            //using Linq
            Console.WriteLine("linq");
            var result = from d in data
                         where d.price > 500
                         select d.name + "--" + d.brand;
            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();
        }

    }

}