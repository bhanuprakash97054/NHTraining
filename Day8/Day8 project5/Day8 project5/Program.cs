using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_project5
{
    /*******************************************************************************
     * Author:Bhanu Rama Krishna Prakash Jakkamsetti
     * Purpose:create list of whatsapp
     * *************************************/
    class Whatsapp
    {
        public int number;
        public string name;
        public string type;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Whatsapp> data = new List<Whatsapp>()
            {
                new Whatsapp { number = 1, name = "bhanu", type = "bussiness" },
                new Whatsapp { number = 2, name = "rama", type = "private" },
                new Whatsapp { number = 3, name = "krishna", type = "private" },
                new Whatsapp { number = 4, name = "prakash", type = "bussiness" },
                new Whatsapp { number = 5, name = "jakkamsettti", type = "private" },
            };
            //for loop
            Console.WriteLine("for loop");
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].type=="private")
                {
                    Console.WriteLine($"number={data[i].number} , name={data[i].name}");
                }
            }
            //foreach loop
            Console.WriteLine("foreach loop");
            foreach (var d in data)
                if (d.type=="private")
                {
                    Console.WriteLine($"number={d.number} , name={d.name}");
                }
            //lambda
            Console.WriteLine("lambda");
            data.Where(d => d.type == "private").ToList().ForEach(d => Console.WriteLine($"number={d.number} , name={d.name}"));
            //linq
            Console.WriteLine("linq");
            var result=from d in data
                       where d.type=="private"
                       select d.number+"--"+d.name;
            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine(); 
        }
    }

}

