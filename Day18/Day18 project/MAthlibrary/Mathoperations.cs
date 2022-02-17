using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAthlibrary
{
    public class Mathoperations
    {
        public static int FindFactorial(int n)
        {
            if (n == 0)
                return 1;
            else if (n > 7)
                return -999;
            else if (n < 0)
                return -9999;
            else
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                    fact *= i;
                return fact;
            }
        }
     public static int IsPalindrome(int num)
        {
            int rem, temp, sum = 0;
            temp = num;
            while (num>0)
            {
                rem = num % 10;
                sum = (sum * 10) + rem;
                num /= 10;
            }
            if (temp==sum)
                Console.WriteLine($"{temp} is palindrome.");
            else
                Console.WriteLine($"{temp} is not palindrome.");
            return temp;
        }

    }
}
