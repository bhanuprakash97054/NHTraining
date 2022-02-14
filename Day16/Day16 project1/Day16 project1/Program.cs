using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_project1
{
    class HelloWorld
    {
        public void ReadData()
        {
            Console.WriteLine("enter data");
            string s=Console.ReadLine();    
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld h = new HelloWorld();
            h.ReadData();
           
            Console.ReadLine();
        }
    }
}
