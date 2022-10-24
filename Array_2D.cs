using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Array_2D
    {
        public static void Main()
        {
            A_2D();
        }

        public static void A_2D()
        {
            int[,] array = new int[,]
            {
                {6,7},
                {1,2},
            };
            int[,] array1 = new int[,]
            {
                {1,2},
                {3,2},
            };

            int sum = 0;
            int sum1=0;
            Console.WriteLine("Addition of 2D array ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                   
                    sum += array[i,j];
                    
                }
                
            }
            Console.WriteLine("Sum of First 2D array = " + sum);
            for (int a=0; a<array1.GetLength(0); a++)
            {
                for(int b=0; b<array1.GetLength(1); b++)
                {
                    sum1 += array1[a, b];
                }
            }
            Console.WriteLine("Sum of Second 2D array = " + sum1);
            int total = sum + sum1; 
            Console.WriteLine("Sum of the 2D array = " + total);
          
        }

    }
}
