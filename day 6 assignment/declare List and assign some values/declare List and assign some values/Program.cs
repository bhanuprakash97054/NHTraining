using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declare_List_and_assign_some_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum=0;
            data.Add(1);
            data.Add(2);    
            data.Add(3);    
            data.Add(4);    
            data.Add(5);    
            data.Add(6);
            foreach (int i in data) 
                sum=sum+i;  
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
