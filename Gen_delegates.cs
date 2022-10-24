using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Gen_delegates
    {
        public delegate T Samp_del<T>(T a);

        class AreaCalc
        {
            /// <summary>
            /// Methods for the int value  for calculating Areas of different shape
            /// </summary>
            /// <param name="a"></param>
            /// <returns></returns>
            public int Square(int a)
            {
                return a * a; // Area of square = a^2
            }
            public int Cube(int a)
            {
                return (6 * a * a); // Area of cube = 6*a^2
            }
            public int Circle(int a)
            {
                return (int)(3.14* a * a); // Area of circle = pi*a^2
            }
            /// <summary>
            /// Methods for the double value for calculating Areas of different shape
            /// </summary>
            /// <param name="a"></param>
            /// <returns></returns>
            public double Square(double a)
            {
                return Math.Round((a * a),2); // Area of square = a^2 with rounding the result to 2 decimal point
            }
            public double Cube(double a)
            {
                return Math.Round((6 * a * a),2); // Area of cube = 6*a^2 with rounding the result to 2 decimal point
            }
            public double Circle(double a)
            {
                return Math.Round((3.14 * a * a),2); // Area of circle = pi*a^2 with rounding the result to 2 decimal point
            }
        }
        static void Main(string[] args)
        {

            AreaCalc areaCalc = new AreaCalc();
            // instance for delegates with area in int
            Samp_del<int> sd = new Samp_del<int>(areaCalc.Square);
            Console.WriteLine("Area of Sqaure in int: " + sd(13));
            sd = areaCalc.Cube;
            Console.WriteLine("Area of Cube in int: " + sd(13));
            sd = areaCalc.Circle;
            Console.WriteLine("Area of Circle in int: " + sd(13));
            Console.WriteLine("-----------------------------------------------");
            // instance for delegates with area in double
            Samp_del<double> sd1 = new Samp_del<double>(areaCalc.Square);
            Console.WriteLine("Area of Sqaure in double: " + sd1(10.75));
            sd1 = areaCalc.Cube;
            Console.WriteLine("Area of Cube in double: " + sd1(10.75));
            sd1 = areaCalc.Circle;
            Console.WriteLine("Area of Circle in double: " + sd1(10.75));
        }
      
    }
}
