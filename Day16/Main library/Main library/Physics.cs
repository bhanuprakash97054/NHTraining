using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_library
{
    public class Physics
    {
        /// <summary>
        /// finding velocity
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <param name="t"></param>
        /// <returns>velocity</returns>
        public int Finalvelocity(int u,int a ,int t)
        {
            return u + a * t;
        }
    }
}
