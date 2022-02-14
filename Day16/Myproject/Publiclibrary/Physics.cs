using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publiclibrary
{
    public class Physics
    {
        int u, a, t;
        /// <summary>
        /// reading data
        /// </summary>
        public void Readdata()
        {
            Console.WriteLine("enter u:");
            u=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter t");
            t=Convert.ToInt32(Console.ReadLine());  
        }
        /// <summary>
        /// find velocity
        /// </summary>
        /// <returns>velocity</returns>
        public int Finalvelocity()
        {
            return u + a * t;
        }
    }
}
