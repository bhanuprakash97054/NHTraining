using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_project1
{
    /***********************************************************************************
     * Author:Bhanu Rama Krishna Prakash Jakkamsetti
     *Purpose:  creting Single inheritance
     ***************************************************************************************/
    class Algebra
    {
        /// <summary>
        /// addition operation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a+b</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// difference operation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a-b</returns>
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
    class Totalmaths : Algebra
    {

        /// <summary>
        /// multiplication operation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a*b</returns>
        public int Mul(int a,int b)
        {
            return a * b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Totalmaths t = new Totalmaths();
            Console.WriteLine( t.Add(20,10));
            Console.WriteLine(t.Sub(20, 10));
            Console.WriteLine(t.Mul(20, 10));

        }
    }
}
