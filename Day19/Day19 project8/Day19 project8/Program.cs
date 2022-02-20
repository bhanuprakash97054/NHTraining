using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19_project8
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
            doc.Load("C:\\Krish\\c#\\NHTraining\\Day19\\Products4.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "quantity")
                    {
                        Console.Write($"{childNode.InnerText}, ");
                    }
                    if (childNode.Name == "brand")
                    {
                        Console.Write($"{childNode.InnerText}, ");
                    }
                    if (childNode.Name == "price")
                    {
                        Console.Write($"{childNode.InnerText}, ");
                    }
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
