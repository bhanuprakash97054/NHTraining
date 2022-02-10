using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_project2
{
    /***********************************************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * Purpose:initializing normal properties
     * ***************************************************************************/

    class Averagespeed
    {
        private int time;
        private int distance;
        private int speed;
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
                speed = distance / time;
                return speed;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Averagespeed a=new Averagespeed();
                a.Time = 30;
                a.Distance = 120;
                Console.WriteLine(a.Speed);
            }
        }
    }
}
