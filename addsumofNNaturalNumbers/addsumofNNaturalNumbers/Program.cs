﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addsumofNNaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, sum = 0, i;
            Console.WriteLine("Enter any value");
            input = Convert.ToInt32(Console.ReadLine());    
           for (i = 1; i <=input;i++)
            {
                sum=sum+i;
               
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
