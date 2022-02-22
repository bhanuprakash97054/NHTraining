using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLibrary;

namespace BiginessLogicLibrary
{
    public class EmployeeBLL
    {
        /// <summary>
        /// call dal in bll for add details
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="empName"></param>
        /// <param name="empSalary"></param>
        /// <param name="empAge"></param>
        /// <returns></returns>
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            // TO DO validation
           if (empId < 0)
            {
                Console.WriteLine("id should not be -ve number");
            }
            for (int i = 1; i <= empId; i++)
            {
                if (empId == i)
                {
                    Console.WriteLine("id not same as old value");
                }
            }
            if (empName.Length < 3)
            {
                Console.WriteLine("name must >3 characters");
            }
            if (empSalary < 10000)
            {
                Console.WriteLine("salary more than 10000");
            }
            if (empAge >= 18 && empAge <= 58)
            {
                Console.WriteLine("age only between 18-58");
            }

            //If all validatins are succesful then call DLL
            var result =EmployeeDAL.AddEmployee(empId, empName, empSalary, empAge);
          return result;
        }
        /// <summary>
        /// call dal in bll for get em datails by using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<string> GetEmployeesById(int id)
        {
            
            var result=EmployeeDAL.GetEmployeesById(id);
            return result;
        }
        /// <summary>
        /// call dal in bll for get em datails by using name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<string> GetEmployeesByNAme(string name)
        {
            var result = EmployeeDAL.GetEmployeesByNAme( name);
            return result;
        }
        /// <summary>
        /// call dal in bll for get all emp details
        /// </summary>
        /// <returns></returns>
        public static string[] GetAllEmployees()
        {
            var result= EmployeeDAL.GetAllEmployees();  
            return result;
        }
    }
}
