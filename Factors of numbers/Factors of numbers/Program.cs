using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors_of_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i;
            Console.WriteLine("enter value");
            input=Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=input;i++)
            {
                if(input % i==0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
