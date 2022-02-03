﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppt_linear_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program search = new Program();
            int[] search_list = new int[] { 3, 5, 12, 5, 28, 16, 20, 35, 9 };

            int n, res;
            Console.WriteLine("Enter a value to search: ");
            n = Convert.ToInt32(Console.ReadLine());

            res = search.LinearSearch(search_list, n);

            if (res >= 0)

                Console.WriteLine("The target value " + n + " is found at position " + res);
            else
                Console.WriteLine("Target Not Found");

            Console.ReadLine();

        }
        int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (target == arr[i])
                    return (i + 1);
            }

            return -1;

            Console.ReadLine();
        }
    }
}
