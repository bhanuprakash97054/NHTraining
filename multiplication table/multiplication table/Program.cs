using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i ;
            Console.WriteLine("enter value");
            input=Convert.ToInt32(Console.ReadLine());
            for ( i = 1; i <=10; i++)

            {

                Console.WriteLine($"{input}*{i}={input*i}");
            }
        }
    }
}
