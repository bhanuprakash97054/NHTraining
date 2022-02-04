using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_project5
{
    class ENglanguage
    {
        public void Printhii()
        {
            Console.WriteLine("hii");
        }
        public void Printhello()
        {
            Console.WriteLine("hello");
        }
        public virtual void Printgoodmrng()
        {
            Console.WriteLine("good morning");
        }
    }
    class Tellanguage : ENglanguage
    {
        public override void Printgoodmrng()
        {
            Console.WriteLine("shubudhayam");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ENglanguage e = new ENglanguage();
            e.Printhello();
            e.Printhii();   
            e.Printgoodmrng();
            Tellanguage t = new Tellanguage();
            t.Printhii();
            t.Printhello();
            t.Printgoodmrng();
        }
    }
}
