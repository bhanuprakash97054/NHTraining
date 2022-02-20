using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_project2
{
    // ***********************************
    // Author :bhanu rama krishna prakash jakkamsetti
    // Purpose :deal with nullable
    // ***********************************

    internal class Program
    {
        static void Main(string[] args)
        {
            int? salary = 45000;
            Console.WriteLine(salary);
            byte? experience = null;
            if (experience.HasValue)
                Console.WriteLine(experience * experience);
            else
                Console.WriteLine("No Value");
            Console.ReadLine();
        }
    }
}
