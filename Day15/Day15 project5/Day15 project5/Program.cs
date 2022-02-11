using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_project5
{
    /*************************************
  * Author:bhanu rama krishna prakash jakkamsetti
  * purpose :copy data automatically whose anme and result
  * *************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            string name;
            Console.WriteLine("Enter your name");
            StreamWriter sw = new StreamWriter("C:\\krish\\c#\\Day15\\queizdata\\Quiez.text", true);
            sw.WriteLine(name = Console.ReadLine());
            Console.WriteLine("*************");
            Console.WriteLine("Hi {0},Welcome to quiz by bhanu", name);
            Console.WriteLine("*************");

            Console.WriteLine("Q1.what is pk 1st movie:");
            Console.WriteLine("1.kushi  2.gudumba  3.balu  4.bangaram");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;

            Console.WriteLine("Q2.what is AA 1st movie:");
            Console.WriteLine("1.pushpa   2.gangothri  3.alavaikunta   4.julayee");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;


            Console.WriteLine("Q3.whta is AA new movie:");
            Console.WriteLine("1.pushpa   2.gangothri  3.alavaikunta   4.julayee");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;

            Console.WriteLine("Q4.what is pk new movie:");
            Console.WriteLine("1.kushi  2.gudumba  3.balu  4.bangaram");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;


            Console.WriteLine("Q5.balayya new mve");
            Console.WriteLine("1.akhanda  2.lol  3.het  4.def");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;

            sw.WriteLine(score);
            sw.Close();
            Console.ReadLine();

        }
    }

}
  