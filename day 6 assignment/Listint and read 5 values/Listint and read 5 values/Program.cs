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
            int sum = 0;
            data.Add(1);
            data.Add(2);
            data.Add(3);
            data.Add(4);
            data.Add(5);
            data.Add(6);
            //using for loop
            for (int i = 0; i < data.Count; i++)
                Console.WriteLine(data[i]);
            //using foreach loop
            foreach (var d in data)
                Console.WriteLine(d);
            //using lambda
            data.ForEach(d => Console.WriteLine(d));
            Console.ReadLine();
        }
    }
}
