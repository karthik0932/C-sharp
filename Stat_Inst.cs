using Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Stat_Inst
    {
        public static void Main()
        {
            sum();
            Stat_Inst m = new Stat_Inst();
            m.multi();
        }

        public static void sum()
        {
            Console.WriteLine("Sum");
            int x, y;
            Console.WriteLine("Enter the First Number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of 2 numbers: " + (x + y));
            Console.WriteLine("------------------------");
        }

        public void multi()
        {
            Console.WriteLine("Multiplication");
            int a, b, c;
            Console.WriteLine("Enter the First Number");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication of 3 Numbers: " + a * b * c);
            Console.WriteLine("------------------------");
        }

    }

}
