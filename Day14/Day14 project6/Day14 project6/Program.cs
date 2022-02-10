using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_project6
{
    /*************************************************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * purpose:first number after 1000 which is divisible by 97
     * ***********************************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i =1000; i <= 1097; i++)
            {
                if (i % 97 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
