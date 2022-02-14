using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_project2
{
    /***************************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * purpose:find factorial  by using oops
     * ************************************************/
    class Mathmatics
    {
        int fact = 1, n;
     /// <summary>
     /// read data for factorial
     /// </summary>
        public void ReadData()
        {
            Console.WriteLine("enter number");
             n =Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// find factorial
        /// </summary>
        /// <returns>factorial</returns>
        public int Factorial()
        {
            for (int i = 1; i <= n; i++)
            fact=fact*i;
           return fact;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathmatics m = new Mathmatics();
            m.ReadData();
           int b= m.Factorial();
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
