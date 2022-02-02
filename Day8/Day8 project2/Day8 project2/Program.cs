using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_project2
{
    /*******************************************************************************
     * Author:Bhanu Rama Krishna Prakash Jakkamsetti
     * Purpose:create list of employee
     * *************************************/
    class Employee
    {
        public int id;
        public string name;
        public int salary;
       
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Employee> data = new List<Employee>()
            {
               new Employee() { id = 1, name ="bhanu",salary =4500},
                new Employee() { id = 2, name = "rama", salary = 6000 },
                 new Employee() { id = 3, name = "krishna", salary = 4000 },
                  new Employee() { id = 4, name = "prakash", salary = 8000 },
                   new Employee() { id = 5, name = "jakkamsetti", salary = 3000 }
            };

            //by using forloop
            Console.WriteLine("for loop");
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].salary > 5000)
                {
                    Console.WriteLine(data[i].name);
                }
            }
            //by using foreach loop
            Console.WriteLine("foreach loop");
            foreach (var d in data)
            {
                if (d.salary > 5000)
                {
                    Console.WriteLine(d.name);
                }
            }
            //by using lambda expression
            Console.WriteLine("lambda");
            data.Where(d => d.salary > 5000).ToList().ForEach(d => Console.WriteLine(d.name));
            //using Linq
            Console.WriteLine("linq");
            var result = from d in data
                         where d.salary > 5000
                         select d.name;
            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();
        } 
    }
}
