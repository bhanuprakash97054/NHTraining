using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_project6
{
    /*******************************************************
* Author: Bhanu Rama Krishna Prakash Jakkamsetti
* Purpose: print values by sorting
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
                new Employee() { id = 2, name = "rama", salary = 6500 },
                new Employee() { id = 3, name = "krishna", salary = 3000 },
                new Employee() { id = 4, name = "prakash", salary = 5000 },
              };
            //by using forloop
            for (int i = 0; i < e.Length; i++)
            {
               
                if (e[i].salary >= 5000)
                {
                 
                    Console.WriteLine($"id={e[i].id} , name={e[i].name} , salary={e[i].salary}");
                }
            }
            //by using foreach loop
            foreach (var a in e)
            {

                
                if (a.salary >= 5000)
                {
                   
                    Console.WriteLine($"id={a.id} , name={a.name} , salary={a.salary}");

                }

            }
            //by using lambda expression

            e.ToList().ForEach(a => Console.WriteLine($"id={a.id} , name={a.name} , salary={a.salary}"));

          
            e.ToList().Where(a => a.salary >= 5000).ToList().ForEach(a => Console.WriteLine($"id={a.id} , name={a.name} , salary={a.salary}"));
         }
    }
}
