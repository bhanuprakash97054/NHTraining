using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_project2
{
    /*******************************************************
    * Author: Bhanu Rama Krishna Prakash Jakkamsetti
    * Purpose: create class for customer
    * *****************************************************/
    internal class Customer
    {
        private int id;
        private string name;
        private int age;
        public void ReadEmployee()
        {
            Console.WriteLine("Enter id:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"id={id} , name={name} , salary={age}");
        }
    }

}
