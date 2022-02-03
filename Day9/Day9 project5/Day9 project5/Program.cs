using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_project5
{
    /*********************************************************************************
     * Author:Bhanu Rama Krishna Prakash Jakkamsetti
     * Purpose:create employee class and access by using constructor
     * **********************************************************************************/
    class Employee
    {
        private int id;
        private string name;
        private int salary;
        public static string companyname = "NB healthcare technology";
        /// <summary>
        /// creating zero argument cunstructor
        /// </summary>
        public Employee()
        {
            this.id = 0;
            this.name = "null";
            this.salary = 0;
        }
        /// <summary>
        /// creating argument cunstructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        public Employee(int id,string name,int salary)
        {
            this.id = id;   
            this.name = name;   
            this.salary = salary;   
             
        }
        /// <summary>
        /// printing the data
        /// </summary>
        public void Printdata()
        {
            Console.WriteLine($"id={id} , name={name} , salary={salary} , campanyname={companyname}");
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Printdata(); 
            Employee e2 = new Employee(1, "bhanu" , 1000);
            e2.Printdata(); 
            Console.ReadLine();
        }
    }
}

   