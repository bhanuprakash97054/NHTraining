using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_evng_project1
{
    /**********************************************************************
     * Author:Bhanu Rama Krishna Prakash Jakkamsetti
     * Purpose:creating  abstract class and methods
     * ********************************************************************/
    abstract class Salary
    {
        /// <summary>
        /// creating pf 
        /// </summary>
        /// <param name="basic"></param>
        /// <returns>pf</returns>
        public int GetPF(int basic)
        {
            return 12 * basic / 100;
        }
        /// <summary>
        /// crating hra
        /// </summary>
        /// <param name="basic"></param>
        /// <returns>hra</returns>
        public int GetHRA(int basic)
        {
            return 40 * basic / 100;
        }
        /// <summary>
        /// creating abstract CA
        /// </summary>
        /// <returns></returns>
        public abstract int GetCA();
        /// <summary>
        /// creating abstract SA
        /// </summary>
        /// <returns></returns>
        public abstract int GetSE();
       
    }
    class NB : Salary
    {
        /// <summary>
        /// implementing abstract getca
        /// </summary>
        /// <returns>ca</returns>
        public override int GetCA()
        {
            return 2000;
        }

        /// <summary>
        /// implementing abstract getsa
        /// </summary>
        /// <returns>sa</returns>
        public override int GetSE()
        {
            return 1000;
        }
    }
    class Google : Salary
    {

        /// <summary>
        /// implementing abstract getca
        /// </summary>
        /// <returns>ca</returns>
        public override int GetCA()
        {
            return 4000;
        }
        /// <summary>
        /// implementing abstract getsa
        /// </summary>
        /// <returns>sa</returns>
        public override int GetSE()
        {
            return 3000;
        }
    }
    class IBM : Salary
    {

        /// <summary>
        /// implementing abstract getca
        /// </summary>
        /// <returns>ca</returns>
        public override int GetCA()
        {
            return 6000;
        }
        /// <summary>
        /// implementing abstract getsa
        /// </summary>
        /// <returns>sa</returns>
        public override int GetSE()
        {
            return 5000;
        }
    }
    class FB : Salary
    {

        /// <summary>
        /// implementing abstract getca
        /// </summary>
        /// <returns>ca</returns>
        public override int GetCA()
        {
            return 8000;
        }
        /// <summary>
        /// implementing abstract getsa
        /// </summary>
        /// <returns>sa</returns>

        public override int GetSE()
        {
            return 7000;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("procesess success");
            Console.ReadLine(); 
        }
    }
}
