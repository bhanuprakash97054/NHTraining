using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_project5
{
    /***********************************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * purpose:use continue keyword
     * **********************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=30; i++)
            {
                if (i%3==0)
                 continue;
                    Console.Write($"{i} ");
            }
            Console.ReadLine();
        }
    }
}
