using ClintApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClintApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient w = new WebService1SoapClient();
            Console.WriteLine(w.Factorial(5));
            Console.WriteLine(w.Add(15,5));
            Console.WriteLine(w.Mul(15,5));
            Console.WriteLine(w.Div(15,5));
        }
    }
}
