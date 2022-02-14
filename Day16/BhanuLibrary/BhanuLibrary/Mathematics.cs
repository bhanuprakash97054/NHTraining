using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhanuLibrary
{
    /***************************************************
 * Author:bhanu rama krishna prakash jakkamsetti
 * purpose:creating library
 * ************************************************/

    internal class Mathematics
    {
        int fact = 1, n;
        /// <summary>
        /// read data for factorial
        /// </summary>
        public void ReadData()
        {
            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// find factorial
        /// </summary>
        /// <returns>factorial</returns>
        public int Factorial()
        {
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;
        }


    }
}
