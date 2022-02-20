using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_project1
{
    // ***********************************
    // Author :bhanu rama krishna prakash jakkamsetti
    // Purpose :illustrate the use of delegates.
    // ***********************************
    public delegate void Operations(int a, int b);
    internal class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
        {
            Operations lol = new Operations(Add);

            lol += Div;
            lol += Mul;

            //15,16
            lol(15, 16);

            // 12,13
            lol(12, 13);

            // 14,18
            lol(14, 18);
          
            Console.ReadLine();
        }
    }
}
