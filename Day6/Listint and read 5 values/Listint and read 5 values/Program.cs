using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listint_and_read_5_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum1 = 0,sum2 = 0,sum3 = 0; 
            data.Add(1);
            data.Add(2);
            data.Add(3);
            data.Add(4);
            data.Add(5);
            data.Add(6);
            //using for loop
            for (int i = 0; i < data.Count; i++)
                sum1=sum1+data[i];
                Console.WriteLine($"by using forloop {sum1}");
            //using foreach loop
            foreach (var d in data)
                sum2=sum2+d;    
                Console.WriteLine($"by using foreach loop {sum2}");
            //using lambda         
            data.ForEach(d => sum3 = sum3 + d ) ;
            Console.WriteLine($"by using lambda {sum3}");
            Console.ReadLine();
        }
    }
}
