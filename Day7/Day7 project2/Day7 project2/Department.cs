using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_project2
{
    /*******************************************************
    * Author: Bhanu Rama Krishna Prakash Jakkamsetti
    * Purpose: create department class
    * *****************************************************/
    internal class Department
    {
        public int number;
        public string name;
        public string type;
        public void ReadEmployee()
        {
            Console.WriteLine("Enter number:");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter type:");
            type = Console.ReadLine();
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"id={number} , name={name} , salary={type}");
        }
    }
}
