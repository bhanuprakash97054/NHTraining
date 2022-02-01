using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_project1
{
    /*******************************************************
     * Author: Bhanu Rama Krishna Prakash Jakkamsetti
     * Purpose: ReadEmployee and PrintEmployee by create an object and call methods.
     * *****************************************************/
   class Employee
    {
        public int id;
        public string name;         
        public int salary;
        public void ReadEmployee()
        {
            Console.WriteLine("Enter id:");
            id =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"id={id} , name={name} , salary={salary}");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            {
                emp.ReadEmployee(); 
                emp.PrintEmployee();
                Console.ReadLine();
            }
        }
    }
}
