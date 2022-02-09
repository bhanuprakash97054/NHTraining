using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_project2
{
    /***********************************************************
      * author: Bhanu rama krishna Prakash jakkamsetti
      * purpose:initialize the values for 2d array
      * **********************************************************/

    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 4, 5 }, { 6, 7 }, { 8, 9 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j] + "  ");
                }
                Console.Write("\n");

            }
            Console.ReadLine();

        }
    }
}



