using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematicslibrary;
namespace Day18_project
{
    /**************************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * purpose:acces methods from ohter assembly by creating library
     * **************************************************/
    public class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("enter number");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Algebra.Factorial(a));
            Console.ReadLine();
        }
    }
}
