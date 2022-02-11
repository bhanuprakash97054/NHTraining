using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_project1
{
    /*********************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * Purpose:using FIle methods
     * ***********************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            // File.Create("C:\\krish\\c#\\Day15\\filecopy\\Hello.text");
            // Console.WriteLine("file created");
            //File.WriteAllText("C:\\krish\\c#\\Day15\\filecopy\\Hello.text", "hello hii this is bhanu");
            // Console.WriteLine("add data inside file");
            // Console.WriteLine(File.GetCreationTime("C:\\krish\\c#\\Day15\\filecopy\\Hello.text"));
            // Console.WriteLine("time");
            // Console.WriteLine(File.Exists("C:\\krish\\c#\\Day15\\filecopy\\Hello.text"));
            //Console.WriteLine(File.GetCreationTimeUtc("C:\\krish\\c#\\Day15\\filecopy\\Hello.text"));
            /* using (StreamWriter sw = File.AppendText("C:\\krish\\c#\\Day15\\filecopy\\Hello.text"))
             {
                 sw.WriteLine("bhanu");
                 sw.WriteLine("LOL");
             }
             Console.WriteLine("new text added");*/
            //  File.Copy("C:\\krish\\c#\\Day15\\filecopy\\Hello.text","C:\\krish\\c#\\Day15\\new server\\Hello.text");
            //  Console.WriteLine("file copied");
            // File.Move("C:\\krish\\c#\\Day15\\filecopy\\Hello.text", "C:\\krish\\c#\\Day15\\filemove\\Hello.text");
            // File.Delete("C:\\krish\\c#\\Day15\\filemove\\Hello.text");
            // Console.WriteLine("file deleted");
           string s= File.ReadAllText("C:\\krish\\c#\\Day15\\new server\\Hello.text");
            Console.WriteLine(s);
            Console.WriteLine("read data in file");
        }
    }
}
