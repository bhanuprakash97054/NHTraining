using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_project4
{
    /*************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * purpose :copy file automatically by using tast scheduler
     * *************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("C:\\krish\\c#\\Day15\\filecopy\\Hello.text", "C:\\krish\\c#\\Day15\\filemove\\Hello.text");
            Console.WriteLine("file copied");
        }
    }
}
