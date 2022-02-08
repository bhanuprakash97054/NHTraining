using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_project3
{
    /********************************************************************
  * Author:Bhanu rama krishna prakash jakkmsetti
  * purpose:exception handling by using final block
  * ***********************************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                int a, b, c;
                Console.WriteLine("enter a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter b");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine(c);
                int[] arr = new int[5];
                arr[8] = 1;
                Console.ReadLine();
            }
            catch (OverflowException e)
            {
                Console.WriteLine("enter value in 0-5000 only");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("divide by zero will not allow");
            }
            catch (FormatException e)
            {
                Console.WriteLine("in correct format or input");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("check the index value is with in range only");
            }
            catch (Exception e)
            {
                Console.WriteLine("contact bhanu ");
            }
            finally
            {
                Console.WriteLine(" designed by Bhanu");
            }
        }
    }
}