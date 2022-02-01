using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Customer customer = new Customer();  
            Product product = new Product();    
            Seller seller = new Seller();   
            Department department = new Department();
            customer.ReadEmployee();
            customer.PrintEmployee();
            product.ReadEmployee();
            product.PrintEmployee();
            seller.ReadEmployee();
            seller.PrintEmployee();
            department.ReadEmployee();
            department.PrintEmployee();
            Console.ReadLine();
            
        }
    }
}
