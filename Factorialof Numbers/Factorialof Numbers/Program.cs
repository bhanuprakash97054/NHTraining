using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorialof_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, product=1;
            Console.WriteLine("Enter number");
            input=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=input; i++)
            
            {
             product=product*i;
                 
                
            }
            Console.WriteLine(product);
            Console.ReadLine();
        }
    }
}
