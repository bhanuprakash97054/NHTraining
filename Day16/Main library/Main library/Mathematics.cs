using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_library
{
    /***************************************************
 * Author:bhanu rama krishna prakash jakkamsetti
 * purpose:creating library and access by using console
 * ************************************************/

    public class Mathematics
    {
        /// <summary>
        /// finding factorial
        /// </summary>
        /// <param name="a"></param>
        /// <returns>factorial</returns>
        public int Factorial(int a)
        {
            int fact = 1;
            for (int i = 1; i <= a; i++)
            fact=fact*i;
            return fact;
        }
        /// <summary>
        /// finding add
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>add</returns>
        public int Add(int a,int b)
        {
            return a + b;
        }
        /// <summary>
        /// finding mul
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>mul</returns>
        public int MUl(int a,int b)
        {
            return a*b;

        }
    }
}
