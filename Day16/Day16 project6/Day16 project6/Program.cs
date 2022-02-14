using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_project6
{
    /******************************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * Purpose:check number is palindrome or not
     * *******************************************************/
    class Numberchecking
    {
        int n, r, sum = 0, temp;
        /// <summary>
        /// for read data
        /// </summary>
        public void Readdata() 
        {
            Console.WriteLine("Enter the Number: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// to find palindrome
        /// </summary>
        public void Palindrome()
        {
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Number is Palindrome.");
            else
                Console.WriteLine("Number is not Palindrome");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
         Numberchecking nc = new Numberchecking();
            nc.Readdata();
            nc.Palindrome();    
            Console.ReadLine();
        }
    }

}
