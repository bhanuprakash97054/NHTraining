using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_project7
{
    /*************************************************************************
    * Author:bhanu rama krishna prakash jakkamsetti
    * purpose:declaring normal method in interface
    * ***********************************************************************/
    interface IStudent
    {
        int Id { get; set; }   
        string Name { get; set; }

        public void PrintHi();
       
    }
    class Lol : IStudent
    {
        public void PrintHi()
        {
            Console.WriteLine("hiiiiii");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
