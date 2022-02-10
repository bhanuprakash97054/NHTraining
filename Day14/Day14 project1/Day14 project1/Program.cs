using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_project1
{
    /***********************************************************************
     * Author:bhanu rama krishna prakash jakkamsetti
     * Purpose:creating sealed class
     * ***************************************************************************/
   sealed class Police
    {
        public static int EmgNumber = 100;
        public string TakeAction()
        {
            return "Tke Action immidiatly";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Police p = new Police();
            Console.WriteLine(Police.EmgNumber);
            Console.WriteLine(p.TakeAction());
        }
    }
}
