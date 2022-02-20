using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_project3
{
    /*******************************************
     * author : bhanu rama krishna prakash jakkamsetti 
     * purpose : Deal with out keyword
     * ****************************************/
    internal class Program
    {
        public  static void Sum(out int i)
        {
            i = 60;
            i += 60;
        }
        static void Main(string[] args)
        {
            int i;
            Sum(out i);
            Console.WriteLine($"Sum of Value is : {i}");

            Console.ReadLine();
        }

    }
}
