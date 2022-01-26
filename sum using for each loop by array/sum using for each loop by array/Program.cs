using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_using_for_each_loop_by_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] data = new int[4];
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter number");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int a in data)
            {
                sum += a;

            }
            Console.WriteLine(sum);
        }
    }
}
