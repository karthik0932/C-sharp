using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Enumeratin
    {
        public enum shape
        {
            square,
            circle
        }
        
        public  void perimeter(int num, shape s)
        {
            if(s==shape.square)
            {
                Console.WriteLine("Perimeter of Square: " + (4 * num));
            }
            else
            {
                Console.WriteLine("Perimeter of Circle: " + (2 * 3.14 * num));
            }
        }

        public static void Main()
        {
            Enumeratin e= new Enumeratin();
            e.perimeter(5, Enumeratin.shape.square);
            e.perimeter(3, Enumeratin.shape.circle);

        }
    }
}
