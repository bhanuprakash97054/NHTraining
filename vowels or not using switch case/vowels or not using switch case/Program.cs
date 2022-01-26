using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowels_or_not_using_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
          
            Console.WriteLine("enter any character");
           ch=char.Parse(Console.ReadLine());
            switch (ch)

            {
                
                case 'A' :
                case 'E' :
                case 'I' :
                case 'O' :
                case 'U' :
                case 'a' :
                case 'e' :
                case 'i' :
                case 'o' :
                case 'u' :
               
                    Console.WriteLine($"{ch} is vowel");
                   break;
                default:
                    Console.WriteLine($"{ch} is not a vowel");
                    break;
            }
        }
    }
}
