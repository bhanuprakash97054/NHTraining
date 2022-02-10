using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_project4
{
    /*********************************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * purpose:print prime by using break
     * *********************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 78, i;
            for ( i = 2; i < n; i++)
            {
                if (n % i == 0)
                    break;
            }
            if (i == n)
            {
                Console.WriteLine("is prime");
            }
            else 
            { 
                Console.WriteLine("not prime");
            }
        }
    }
}
