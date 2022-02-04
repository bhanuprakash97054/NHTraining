using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_project3
{
   /***********************************************************************************
     * Author:Bhanu Rama Krishna Prakash Jakkamsetti
     *Purpose:  Method overloading
     ***************************************************************************************/
    class Algebra
    {
        /// <summary>
        /// addition operation with 2 paramaeters
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a+b</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
      /// <summary>
      /// addition operation with 3 parameters
      /// </summary>
      /// <param name="a"></param>
      /// <param name="b"></param>
      /// <param name="c"></param>
      /// <returns>a+b+c</returns>
        public int Add(int a, int b ,int c)
        {
            return a+b+c;
        }
        /// <summary>
        /// addition operation with 4 parameters
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns>a+b+c+d</returns>
        public int Add(int a,int b, int c,int d)
        {
            return a+b+c+d;
        }
    }   
    internal class Program
    {
        static void Main(string[] args)
        {
            Algebra t = new Algebra();
            Console.WriteLine(t.Add(20,10));
            Console.WriteLine(t.Add(20,10,30));
            Console.WriteLine(t.Add(20,10,30,40));
        }
    }
}
