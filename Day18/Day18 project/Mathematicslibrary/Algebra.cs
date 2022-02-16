using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematicslibrary;

namespace Mathematicslibrary
{
    public class Algebra
    {
        /// <summary>
        /// finding facttorial
        /// </summary>
        /// <param name="a"></param>
        /// <returns>factorial</returns>
        public static int Factorial(int a)
        {
            if (a == 0)
                return 1;
            else if (a > 7)
                return -999;
            else if (a < 0)
                return -9999;
            else
            {
                int fact = 1;
                for (int i = 1; i <=a; i++)
                    fact *= i;
                return fact;    
            }
        }
    }
}
