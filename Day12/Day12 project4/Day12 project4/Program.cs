using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_project4
{
    internal class Program
    {

       static void Print(int a)
        {
            Console.WriteLine(a);
            Print(++a);
        }
        static void Main(string[] args)
        {
            try
            {
                Print(0);
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine("recursion error");
                Console.ReadLine();
            }
        }
    }
}
