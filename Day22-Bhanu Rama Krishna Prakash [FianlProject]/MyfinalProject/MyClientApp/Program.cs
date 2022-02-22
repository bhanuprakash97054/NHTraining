using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiginessLogicLibrary;

namespace MyClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
              int ch;

              do
              {
                  Console.WriteLine("**************************");
                  Console.WriteLine("Employee Management Application");
                  Console.WriteLine("**************************");
                  Console.WriteLine("1.Add Employee details:");
                  Console.WriteLine("2.search Employee by Id:");
                  Console.WriteLine("3.search Employee by Name:");
                  Console.WriteLine("4.Display All Employees:");
                  Console.WriteLine("Enter Your choice");
                  ch = Convert.ToInt32(Console.ReadLine());
                  switch (ch)
                  {
                      case 1:
                          AddEpmloyee();
                          break;
                      case 2:
                          SearchEmployeeById();
                          break;
                      case 3:
                          SearchEmployeeByName();
                          break;
                      case 4:
                          DisplayAllEmployees();
                          break;
                      default:
                          Console.WriteLine("invadid option");
                          break;
                  }
                  Console.WriteLine("Do you want to continue (y/n):");
                  choice = Console.ReadLine();
              }
              while (choice.Equals("y"));
            Console.ReadLine();

        }
        /// <summary>
        /// read all emp data
        /// </summary>
         public static void AddEpmloyee()
              {
                 int id, salary, age;
                 string name;
                Console.WriteLine("enter id:");
                 id=Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("enter salary:");
                 salary = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("enter age:");
                 age = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("enter name:");
                 name = Console.ReadLine();

               //call BLL
                 var result = EmployeeBLL.AddEmployee(id,name, salary, age);
           
            if (result)
                  Console.WriteLine("employee details saved succesfully");
                else
                  Console.WriteLine("error");
         }
        /// <summary>
        /// search emp data by id
        /// </summary>
         public static void SearchEmployeeById()
        
         {
                int id;
                Console.WriteLine("enter id");
                id = Convert.ToInt32(Console.ReadLine());
            //call BLL
                var result = EmployeeBLL.GetEmployeesById(id);
                if (result.Count==0)
                  Console.WriteLine("no records found");
              else
              {
                  foreach (var item in result)
                  {
                      Console.WriteLine(item);
                  }
              }    
         }
        /// <summary>
        /// search emp data by name
        /// </summary>
        public static void SearchEmployeeByName()
         {
                string name;
                Console.WriteLine("enter name");
                name =Console.ReadLine();
            //Call BLL
                var result=EmployeeBLL.GetEmployeesByNAme(name);
                  foreach (var item in result)
                  {
                      Console.WriteLine(item);
                  }

         }
        /// <summary>
        /// display all employee details
        /// </summary>
         public static void DisplayAllEmployees()
         {
            //Call BLL
               var result=EmployeeBLL.GetAllEmployees();
               foreach (var item in result)
               {
                Console.WriteLine(item);
               }
         }
           
        
    }
}
