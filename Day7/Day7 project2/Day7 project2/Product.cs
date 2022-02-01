using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_project2
{
    /*******************************************************
    * Author: Bhanu Rama Krishna Prakash Jakkamsetti
    * Purpose: create product class
    * *****************************************************/
    internal class Product
    {
        public int id;
        public string brand;
        public int price;
        public void ReadEmployee()
        {
            Console.WriteLine("Enter id:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter brand:");
            brand = Console.ReadLine();

            Console.WriteLine("Enter price:");
            price = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"id={id} , name={brand} , salary={price}");
        }
    }
}
