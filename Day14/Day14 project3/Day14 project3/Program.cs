using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_project3
{/***********************************************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * Purpose:initializing auto implemented properties
     * ***************************************************************************/

    class Averagespeed
    {
        private int time;
        private int distance;
       
        public int Time
        {
            set { time = value; }
        }
        public int Distance
        {
            set { distance = value; }
        }
        public int Speed
        {
            get
            {
               return distance / time;
                
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Averagespeed a = new Averagespeed();
                a.Time = 30;
                a.Distance = 120;
                Console.WriteLine(a.Speed);
            }
        }
    }
}
