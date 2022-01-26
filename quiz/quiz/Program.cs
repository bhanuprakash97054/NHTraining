using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            String name;
            
            Console.WriteLine("enter your name:");
            name = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("====================================================");
            Console.WriteLine($"hii {name} ,welcome to KRISH quiz");
            Console.WriteLine("====================================================");

            Console.WriteLine("Q1-pawan kalyan new movie name");
            Console.WriteLine("1.kushi 2.bangaram 3.bheemla nayak 4.faskk");
            Console.WriteLine("enter ur option");
            ans=Convert.ToInt32((String)Console.ReadLine());
            if (ans == 3) 
            {
                score += 20;
            }
            Console.WriteLine("Q2-ALLU ARJUN new movie name");
            Console.WriteLine("1.desamudhuru 2.arya 3.alavaikunta puramlo 4.Pushpaa");
            Console.WriteLine("enter ur option");
            ans = Convert.ToInt32((String)Console.ReadLine());
            if (ans == 4)
            {
                score += 20;
            }

            Console.WriteLine("Q3-ALLU ARJUN 1st movie name");
            Console.WriteLine("1.gangothri 2.arya 3.alavaikunta puramlo 4.Pushpaa");
            Console.WriteLine("enter ur option");
            ans = Convert.ToInt32((String)Console.ReadLine());
            if (ans == 1)
            {
                score += 20;
            }

            Console.WriteLine("Q4-pawan kalyan 1st movie name");
            Console.WriteLine("1.desamudhuru 2.kushi 3.alavaikunta puramlo 4.Pushpaa");
            Console.WriteLine("enter ur option");
            ans = Convert.ToInt32((String)Console.ReadLine());
            if (ans == 2)
            {
                score += 20;
            }

            Console.WriteLine("Q5-balayya babu new movie name");
            Console.WriteLine("1.desamudhuru 2.arya 3.alavaikunta puramlo 4.Akhanda");
            Console.WriteLine("enter ur option");
            ans = Convert.ToInt32((String)Console.ReadLine());
            if (ans == 4)
            {
                score += 20;
            }
            Console.WriteLine("====================================================");
            if (score>=60)

            {
                Console.WriteLine($"congragulations {name} , u got {score}% in this quiz");
           
            }
            else
            {
                Console.WriteLine($"sry {name}, u got only{score}% try again");
            }
            Console.WriteLine("====================================================");
        }
    }
}
