using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_project6
{
    /***********************************************************
      * author: Bhanu rama krishna Prakash jakkamsetti
      * purpose: product of two matrices
      * **********************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] data = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter 1st array value");
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++) { }
            }
            int[,] data2 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter 2nd array value");
                    data2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    Console.Write(data[i, j] * data2[i, j] + " ");
                }
                Console.Write("\n");
            }


            Console.ReadLine();

        }
    }
}
