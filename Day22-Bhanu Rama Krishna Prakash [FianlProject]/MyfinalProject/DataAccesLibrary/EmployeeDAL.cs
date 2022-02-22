using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLibrary
{
    /************************************************************
     * author:bhanu rama krishna prakash jakkamsetti
     * prpose:3 layer archtecture
     * ***********************************************************/
    public static class EmployeeDAL
    {
       public  static string Filepath = "C:\\Krish\\c#\\NHTraining\\Day22-Bhanu Rama Krishna Prakash [FianlProject]\\EmployeeData.txt";
        /// <summary>
        /// adding all emp details
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="empName"></param>
        /// <param name="empSalary"></param>
        /// <param name="empAge"></param>
        /// <returns>bool</returns>
        public static bool AddEmployee(int empId,string empName,int empSalary,int empAge)
        {
            try
            {
                string textcontent = string.Concat(empId, ",", empName, ",", empSalary, ",", empAge);
                File.AppendAllText(Filepath, textcontent + Environment.NewLine);
                return true;
            }
            catch (Exception e)
            {
                 return false;
            }
        }
        /// <summary>
        /// get emp details by using id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>string</returns>
        public static List<string> GetEmployeesById(int id)
        {
            var allEMployees = File.ReadAllLines(Filepath);
            bool isfound=false;
            List<string> employeeFound = new List<string>();
            foreach (string employee in allEMployees)
            {
               var empDetails=employee.Split(',');
                if (Convert.ToInt32(empDetails[0])==id)
                {
                    isfound =true;
                    employeeFound.Add(employee);
                    break;
                }
            }
           
            return employeeFound;
        }
        /// <summary>
        /// get emp details by using name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>string</returns>
        public static List<string> GetEmployeesByNAme(string name)
        {
            var allEMployees = File.ReadAllLines(Filepath);
            List<string> employeeFound = new List<string>();
            foreach (string employee in allEMployees)
            {
                var empDetails = employee.Split(',');
                if (empDetails[1].Contains(name))
                {  
                    employeeFound.Add(employee);
                }
            }
            return employeeFound;
        }
        /// <summary>
        /// get all emp details
        /// </summary>
        /// <returns>string</returns>
        public static string[] GetAllEmployees()
        {
            var allEmployees=File.ReadAllLines(Filepath);
            return allEmployees;
        }
    }
}
