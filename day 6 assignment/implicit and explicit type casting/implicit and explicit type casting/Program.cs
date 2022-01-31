using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implicit_and_explicit_type_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit type casting
            short a = 10;
            int b = a;
            Console.WriteLine(b);

            //explicit type casting
            int c = 20;
            short d = (short)c;
            Console.WriteLine(d);

        }
    }
}
