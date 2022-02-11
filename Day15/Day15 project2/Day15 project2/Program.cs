using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_project2
{
    /*********************************************
    * Author:bhanu rama krishna prakash jakkamsetti
    * Purpose:using stream writer and reader 
    * ***********************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter s = new StreamWriter("C:\\krish\\c#\\Day15\\filecopy\\Hello.text",true);
            s.WriteLine("may");
            s.WriteLine("june");
            s.WriteLine("july");
            s.WriteLine("aug");
            s.Close();
            Console.WriteLine("write data in old file");
        }
    }
}
