using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_project3
{
    /*********************************************
    * Author:bhanu rama krishna prakash jakkamsetti
    * Purpose:read date using file
    * ***********************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
         string s=   File.ReadAllText("C:\\krish\\c#\\Day15\\filecopy\\Hello.text");
            Console.WriteLine(s);
        }
    }
}

