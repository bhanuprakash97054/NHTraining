using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_project4
{    /*******************************************************
    * Author: Bhanu Rama Krishna Prakash Jakkamsetti
    * Purpose: create array employee 
    * *****************************************************/

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
            Employee[] e = new Employee[]
            {
                new Employee() { id = 1, name ="bhanu",salary=1000},
                new Employee() { id = 2, name = "rama", salary = 2000 },
                new Employee() { id = 3, name = "krishna", salary = 3000 },
                new Employee() { id = 4, name = "prakash", salary = 4000 },
        };
            //by using forloop
            for (int i = 0; i < e.Length; i++)
            {
                Console.WriteLine($"id={e[i].id} , name={e[i].name} , salary={e[i].salary}");
            }
            //by using foreach loop
            foreach (var a in e)
            {
                Console.WriteLine($"id={a.id} , name={a.name} , salary={a.salary}");
            }
            //by using lambda expression
            e.ToList().ForEach(a => Console.WriteLine($"id={a.id} , name={a.name} , salary={a.salary}"));
        }
        
    }
}

