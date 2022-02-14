using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_project5
{
    /***************************************************
* Author:bhanu rama krishna prakash jakkamsetti
* purpose:multiplaction table by using oops
* ************************************************/
    class Maths
    {
        int n;
        /// <summary>
        /// reading data from user
        /// </summary>
        public void Readdata()
        {
            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// printing data
        /// </summary>
        public void Printdata()
        {
            for (int i = 1; i <= 10; i++)
            {
               
                Console.WriteLine($"{n}*{i}={i * n}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths m = new Maths();
            m.Readdata();
            m.Printdata();
            Console.ReadLine();
        }
    }
}
