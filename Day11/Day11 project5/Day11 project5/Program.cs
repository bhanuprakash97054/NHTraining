using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_project5
{
    /***************************************************************************
 * Author:Bhanu Rama Krishna Prakash Jakkamsetti
 * purpose:creating static methods
 * *************************************************************************/
    class Employee
    {
        public int Id;
        public string Name;
        public static string company = "NationsBenifits";
        /// <summary>
        /// for to read data
        /// </summary>
        public void Readdata()
        {
            Console.WriteLine("enter id");
            Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            Name=Console.ReadLine();    
        }
        /// <summary>
        /// to print name
        /// </summary>
        public void Printname()
        {
            Console.WriteLine(Name);
        }
        /// <summary>
        /// print hello 
        /// </summary>
        public static void Hello()
        {
            Console.WriteLine("hello");
        }
    }
    class Mathimatics
    {
        /// <summary>
        /// add 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a+b</returns>
        public static int Add(int a,int b)
        {
            return a + b;
        }
        /// <summary>
        /// multiplication
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a*b</returns>
        public static int Mul(int a,int b)
        {
            return a*b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Employee.company);
            Employee e = new Employee();
            Console.WriteLine(Mathimatics.Add(5,10));
            Console.WriteLine(Math.Pow(5, 2));
        }
    }
}

    
