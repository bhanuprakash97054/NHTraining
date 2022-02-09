using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_project8
{
           /***********************************************************
           * author: Bhanu rama krishna Prakash jakkamsetti
           * purpose: stack
           * **********************************************************/

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();

            data.Push(10);
            data.Push(9);
            data.Push(60);
            data.Push(14);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Pop());
            Console.WriteLine(data.Count);
            

            Console.ReadLine();
        }
    }
}
