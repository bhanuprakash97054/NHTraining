using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_project3
{

    /***************************************************************************
     * Author:Bhanu Rama Krishna Prakash Jakkamsetti
     * purpose:creating properties
     * *************************************************************************/
    class Employee
    {
        private int id; 
        private string name;    
        private string disignation;
        private int salary;
        /// <summary>
        /// creating get and set
        /// </summary>
        public int Id 
        {
            get { return id; } 
            set { id = value; } 
        }
        /// <summary>
        /// creating get and set
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// creating  set
        /// </summary>
        public string Disignation
        {
           
            set {   disignation = value; }
        }
        /// <summary>
        /// creating get
        /// </summary>
        public int Salary
        {
            get 
            {
                salary = (disignation == "M") ? 3000 : 6000;
                return salary;
            }
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Disignation = "M";
            Console.WriteLine(e.Salary);
        }
    }
}
