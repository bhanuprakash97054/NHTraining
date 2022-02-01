using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_project3
{
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
            Employee emp = new Employee() { id=1 ,name="bhanu" ,salary=100000};
            Console.WriteLine($"id={emp.id},name={emp.id},salary{emp.salary}");
            Employee emp2 = new Employee() { id = 2, name = "krish", salary = 200000 };
            Console.WriteLine($"id={emp2.id},name={emp2.id},salary{emp2.salary}");
            Console.ReadLine();
        }
    }
}

