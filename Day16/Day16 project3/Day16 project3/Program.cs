using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main_library;

namespace Day16_project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.Factorial(5);
            m.Add(5, 5);
            m.MUl(5,5);
            Physics p = new Physics();
            p.Finalvelocity(5,2,3);
            Chamistry c = new Chamistry();
            c.Getbenzene();
            c.Getwater();
            c.Methane();
            Console.ReadLine();
        }
    }
}
