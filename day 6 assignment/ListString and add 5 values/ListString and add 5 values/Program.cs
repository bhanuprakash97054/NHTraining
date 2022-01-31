using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListString_and_add_5_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("krish");
            data.Add("bhanu");
            data.Add("meg");
            data.Add("dhivi");
            //using forloop
            for (int i = 0;  i< data.Count; i++)
                Console.WriteLine(data[i]);
            //using foreach loop
            foreach (var d in data)
                Console.WriteLine(d);
            //using lambda
            data.ForEach(d => Console.WriteLine(d));
        }
    }
}
