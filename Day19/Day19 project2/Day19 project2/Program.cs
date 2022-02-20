using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19_project2
{
    /***************************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * purpose:read the data from xml
     * *************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Krish\\c#\\NHTraining\\Day19\\Products3.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string s = node.InnerText;
                Console.WriteLine(s);
            }
        }
    }
}
