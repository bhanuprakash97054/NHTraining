using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_project9
{
    /***********************************************************
         * author: Bhanu rama krishna Prakash jakkamsetti
         * purpose: queue
         * **********************************************************/

    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(64);
            data.Enqueue(25);
            data.Enqueue(54);

            Console.WriteLine(data.Count);
            Console.WriteLine(data.Dequeue());
            Console.WriteLine(data.Count);

            Console.ReadLine();

        }
    }
}
