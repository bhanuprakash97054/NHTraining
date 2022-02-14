using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhanulibrary
{
    /*********************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * purpose:creating library in the same project
     ************************************************/
    public partial class Mathematics
    {
         public int n, fact = 1;
        /// <summary>
        /// read data
        /// </summary>
        public void readdatafact()
        {
            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// find factorial
        /// </summary>
        /// <returns>fact</returns>
        public int Factorial()
        {
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;
        }

        /// <summary>
        /// find mul
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>mul</returns>
        public int Mul(int a,int b)
        {
            return a * b;
        }
    }
}
