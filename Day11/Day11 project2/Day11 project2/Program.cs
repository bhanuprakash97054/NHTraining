using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_project2
{
   
        /***************************************************************************
         * Author:Bhanu Rama Krishna Prakash Jakkamsetti
         * purpose:creating interface class
         * *************************************************************************/
        interface Ishape
        {
            /// <summary>
            /// creating abstract method for parameter
            /// </summary>
            /// <returns></returns>
            int Calculateparameter();
            /// <summary>
            /// creating abstract method for area
            /// </summary>
            /// <returns></returns>
            int Calculatearea();
        }
        class Circle : Ishape
        {
            int radius;
            /// <summary>
            /// to read data
            /// </summary>
            public void Readdradius()
            {
                Console.WriteLine("enter radius");
                radius = Convert.ToInt32(Console.ReadLine());
            }
            /// <summary>
            /// calculate area
            /// </summary>
            /// <returns>area</returns>
            public int Calculatearea()
            {
                return 22 * radius * radius / 7;
            }
            /// <summary>
            /// calculate parameter
            /// </summary>
            /// <returns>parameter</returns>
            public int Calculateparameter()
            {
                return 2 * 22 * radius / 7;
            }
        }
        class Square : Ishape
        {
            int sides;
            /// <summary>
            /// to read data
            /// </summary>
            public void Readsides()
            {
                Console.WriteLine("enter sides value");
                sides = Convert.ToInt32(Console.ReadLine());
            }
            /// <summary>
            /// calculate area
            /// </summary>
            /// <returns>area</returns>
            public int Calculatearea()
            {
                return 4 * sides;
            }
            /// <summary>
            /// calculate parameter
            /// </summary>
            /// <returns>parameter</returns>
            public int Calculateparameter()
            {
                return sides * sides;
            }
        }
        class IsoscelesTriangle : Ishape
        {
            int a, b;
            /// <summary>
            /// to read data
            /// </summary>
            public void Readaandb()
            {
                Console.WriteLine("inter a");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("inter b");
                b = Convert.ToInt32(Console.ReadLine());
            }
            /// <summary>
            /// calculate area
            /// </summary>
            /// <returns>area</returns>
            public int Calculatearea()
            { 
            int A = a * a;
            int B = b * b;
            int area= (int)(0.5 * b * Math.Sqrt(A - B / 2));
            return area;
            }
            /// <summary>
            /// calculate parameter
            /// </summary>
            /// <returns>parameter</returns>
            public int Calculateparameter()
            {
                return (2 * a + b);
            }
        }
        class Rectangle : Ishape
        {
            int length, breadth;
            /// <summary>
            /// to read data
            /// </summary>
            public void Readlandb()
            {
                Console.WriteLine("enter length");
                length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter breadth");
                breadth = Convert.ToInt32(Console.ReadLine());
            }
            /// <summary>
            /// calculate area
            /// </summary>
            /// <returns>area</returns>
            public int Calculatearea()
            {
                return 2 * (length + breadth);
            }
            /// <summary>
            /// calculate parameter
            /// </summary>
            /// <returns>parameter</returns>
            public int Calculateparameter()
            {
                return length * breadth;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Circle c = new Circle();
                c.Readdradius();
                Console.WriteLine(c.Calculatearea());
                Console.WriteLine(c.Calculateparameter());
                Square s = new Square();
                s.Readsides();
                Console.WriteLine(s.Calculatearea());
                Console.WriteLine(s.Calculateparameter());
                IsoscelesTriangle t = new IsoscelesTriangle();
                t.Readaandb();
                Console.WriteLine(c.Calculatearea());
                Console.WriteLine(c.Calculateparameter());
                Rectangle r = new Rectangle();
                r.Readlandb();
                Console.WriteLine(r.Calculatearea());
                Console.WriteLine(r.Calculateparameter());
                Console.ReadLine();
            }
        }
    }

