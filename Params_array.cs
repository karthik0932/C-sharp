using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    //params array
    internal class Params_array
    {
        public static void Main()
        {
            int mult = table(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }


        public static int table(params int[] number)
        {
            Console.WriteLine("Enter the Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int c = 1;
            foreach (int i in number)
            {
                c = (a * i);
                Console.WriteLine("{0} * {1} = {2}",a,i,c);
            }
            return 0;
        }
    }
}
