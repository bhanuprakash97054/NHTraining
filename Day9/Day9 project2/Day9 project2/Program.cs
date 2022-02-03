using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_project2
{
    /*********************************************************************************
     * Author:Bhanu Rama Krishna Prakash Jakkamsetti
     * Purpose:find factorial,factors and isprime by using methods and object
     * **********************************************************************************/
    class Mathsoperation
    {
        private int input;
        /// <summary>
        /// taking input from console
        /// </summary>
        public void Readinput()
        {
            Console.WriteLine("enter number");
            input = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// finding factorial 
        /// </summary>
        /// <returns>factorial</returns>
        public int Factorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        /// <summary>
        /// finding factors
        /// </summary>
        public void Printfactors()
        {
            for (int i = 1; i <= input; i++)
            {
                {
                    if (input % i == 0)
                        Console.WriteLine(i);
                }
            }
        }
        /// <summary>
        /// find the number is prime or not
        /// </summary>
        /// <returns>isprime</returns>
        public bool Isprime()
        {
            int count = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    count++;
            }
            if (count == 2)
                return true;
            else
                return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathsoperation obj = new Mathsoperation();
            obj.Readinput();
            Console.WriteLine(obj.Factorial());
            obj.Printfactors();
            if (obj.Isprime())
                Console.WriteLine("input is prime number");
            else
                Console.WriteLine("input is not prime number");
            Console.ReadLine();
        }

    }
}
