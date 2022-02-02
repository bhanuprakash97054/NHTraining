using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_project4
{

    /*******************************************************************************
 * Author:Bhanu Rama Krishna Prakash Jakkamsetti
 * Purpose:create list of product
 * *************************************/
    class Department
    {
        public int id;
        public string name;
        public int depcount;


    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Department> data = new List<Department>()
            {
               new Department() { id = 1, name ="bhanu",depcount =45},
                new Department() { id = 2, name = "rama", depcount = 60},
                 new Department() { id = 3, name = "krishna", depcount = 40},
                  new Department() { id = 4, name = "prakash", depcount = 80},
                   new Department() { id = 5, name = "jakkamsetti", depcount = 30}
            };

            //by using forloop
            Console.WriteLine("for loop");
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].depcount > 50)
                {
                    Console.WriteLine($"name={data[i].id}, brand={data[i].name}");
                }
            }
            //by using foreach loop
            Console.WriteLine("foreach loop");
            foreach (var d in data)
            {
                if (d.depcount > 50)
                {
                    Console.WriteLine($"name={d.id}, brand={d.name}");
                }
            }
            //by using lambda expression
            Console.WriteLine("lambda");
            data.Where(d => d.depcount > 50).ToList().ForEach(d => Console.WriteLine($"name={d.id}, brand={d.name}"));
            //using Linq
            Console.WriteLine("linq");
            var result = from d in data
                         where d.depcount > 50
                         select d.id + "--" + d.name;
            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();
        }
    }
}
