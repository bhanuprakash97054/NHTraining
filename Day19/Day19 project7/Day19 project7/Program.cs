using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19_project7
{
    /***************************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * purpose:read the data from xml
     * *************************************************/

    internal class Program
    {
        static void Main(string[] args)
        {
            int Quantity;
            Console.WriteLine("Enter  Quantity: ");
            Quantity = Convert.ToInt32(Console.ReadLine());


            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Krish\\c#\\NHTraining\\Day19\\Products4.xml");


            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                bool isMatch = false;
                foreach (XmlNode cnode in node.ChildNodes)
                {
                    if (cnode.Name == "quantity")
                    {
                        if (cnode.InnerText == Quantity.ToString())
                        {
                            isMatch = true;
                        }
                    }
                    if (cnode.Name == "brand" && isMatch)
                    {
                        Console.WriteLine(cnode.InnerText);
                        break;
                    }

                }
            }
            Console.ReadLine();

        }
    }
}
