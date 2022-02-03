using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_project4
{
    /*********************************************************************************
     * Author:Bhanu Rama Krishna Prakash Jakkamsetti
     * Purpose:create employee class and access the variables by using object
     * **********************************************************************************/
    class Employee
    {
        private int id;
        private string name;    
        private int salary;
        public static string companyname = "NB healthcare technology";
        /// <summary>
        /// taking inputs from output
        /// </summary>
        public void Readdata()
        {
            Console.WriteLine("enter employee id");
            id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            name =Console.ReadLine();
            Console.WriteLine("enter employee salary");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// print employee data
        /// </summary>
        public void Printdata()
        {
            Console.WriteLine($"id={id} , name={name} , salary={salary} , company={companyname}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
                e1.Readdata();
                e1.Printdata();
            Employee e2 = new Employee();
                e2.Readdata();
                e2.Printdata();
            Console.ReadLine(); 
        }
    }
}


  
