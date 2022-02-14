using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main_library;

namespace Day16_project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            Console.WriteLine(m.Factorial(5));
            Console.WriteLine( m.Add(5, 5));
            Console.WriteLine(m.MUl(5, 5));
            Physics p = new Physics();
            Console.WriteLine(p.Finalvelocity(5, 2, 3));
            Chamistry c = new Chamistry();
            Console.WriteLine(c.Getbenzene());
            Console.WriteLine(c.Getwater());
            Console.WriteLine(c.Methane());
            Console.ReadLine();
        }
    }
}
