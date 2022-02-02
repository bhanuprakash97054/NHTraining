using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_project1
{
    /*******************************************************************************
     * Author:Bhanu Rama Krishna Prakash Jakkamsetti
     * Purpose:initialize list with 8 values
     * *************************************/
   
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() {11,27,24,26,45,99,84,50 };
            //by using forloop
            Console.WriteLine("for loop");
            for (int i = 0; i <data.Count; i++)
            {
                if (data[i] % 2 == 0)
                {
                    Console.WriteLine(data[i]);
                }
            }
            //by using foreach loop
           Console.WriteLine("foreach loop");
            foreach (var d in data)
            {
                if (d%2==0)
                {
                    Console.WriteLine(d);
                }
            }
            //by using lambda expression
            Console.WriteLine("lambda");
            data.Where(d=>d%2==0).ToList().ForEach(d=>Console.WriteLine(d));
            //using Linq
            Console.WriteLine("linq");
            var result=from d in data
                       where d%2==0
                       select d;
            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine(); 
        }

    }
}
