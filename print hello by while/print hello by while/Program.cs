using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_hello_by_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a<=5)
            {
                Console.WriteLine("hello world");
                a++;
            }
        }
    }
}
