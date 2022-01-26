using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_sum_and_avg_by_using_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] data = new int[5];
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter number");
                data[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
              
            }
            int avg = sum / data.Length;
            Console.WriteLine(sum);
            Console.WriteLine(avg);
        }
    }
}
