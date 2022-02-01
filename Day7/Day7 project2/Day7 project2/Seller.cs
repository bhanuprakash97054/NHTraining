using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_project2
{
    /*******************************************************
    * Author: Bhanu Rama Krishna Prakash Jakkamsetti
    * Purpose: create class for seller
    * *****************************************************/
    internal class Seller
    {
        public int id;
        public string name;
        public int quantity;
        public void ReadEmployee()
        {
            Console.WriteLine("Enter id:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter quantity:");
            quantity = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"id={id} , name={name} , salary={quantity}");
        }
    }
}
