using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day20Project4
{
    // ****************************
    // Author : Bhanu rama krishna prakash Jakkamsetti
    // Purpose : Deal with ref keyword
    // ****************************
    internal class Program
    {
        private static void SetValue(ref string s)
        {
            // Checking parameter value
            if (s == "Hello")
            {
                Console.WriteLine("Welcome to my world");
            }

            // Assigning new value 
            s = "Divya ";

        }
        static void Main(string[] args)
        {
            string s1 = "HIII";
            SetValue(ref s1);
            Console.WriteLine(s1);
            Console.ReadLine();
        }
    }
}

