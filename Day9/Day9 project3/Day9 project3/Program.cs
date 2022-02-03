using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_project3
{

    /*********************************************************************************
     * Author:Bhanu Rama Krishna Prakash Jakkamsetti
     * Purpose:find sum,difference,product and division by using methods and object
     * **********************************************************************************/
    class Arthematic
    {
        private int input1;
        private int input2;
        /// <summary>
        /// taking input from console
        /// </summary>
        public void Readinput()
        {
            Console.WriteLine("enter first number");
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            input2 = Convert.ToInt32(Console.ReadLine());
        }/// <summary>
        /// add two numbers
        /// </summary>
        /// <returns>sum</returns>
        public int Add()
        {
         return input1+input2;
        }
        /// <summary>
        /// difference between 2 numbers
        /// </summary>
        /// <returns>differtence</returns>
        public int Difference()
        {
            return input1 - input2;
        }
        /// <summary>
        /// product of 2 numbers
        /// </summary>
        /// <returns>product</returns>
        public int Product()
        {
            return input1 * input2;
        }
        /// <summary>
        /// division of 2 numbers
        /// </summary>
        /// <returns>division</returns>
        public double Division()
        {
            return (input1 / input2);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Arthematic a = new Arthematic();    
            a.Readinput();
            Console.WriteLine(a.Add());
            Console.WriteLine(a.Difference());
            Console.WriteLine(a.Product());
            Console.WriteLine(a.Division());
        }
    }
}