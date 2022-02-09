using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_project7
{
    /***********************************************************
        * author: Bhanu rama krishna Prakash jakkamsetti
        * purpose: jagged array and print values
        * **********************************************************/

    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[3][];
            names[0] = new char[] { 'j', 'K' };
            names[1] = new char[] { 'b', 'h', 'a', 'n', 'u' };
            names[2] = new char[] { 'p', 'r', 'a', 'k', 'a', 's', 'h' };


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < names[i].Length; j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.Write("\n");
                Console.ReadLine();
            }
        }
    }
}
 