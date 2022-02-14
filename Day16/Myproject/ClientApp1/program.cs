using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bhanulibrary;
using Publiclibrary;



namespace ClientApp1
{
    internal class program
    {
        public static void Main(string [] args)
        {
           Mathematics m=new Mathematics();
            m.readdatafact();
            Console.WriteLine(m.Factorial());
            Console.WriteLine(m.Mul(5,2));
            Console.WriteLine(m.Div(10,5));
            Physics p = new Physics();
            p.Readdata();                       
            Console.WriteLine(p.Finalvelocity());
            Console.ReadLine(); 
        }
    }
}
