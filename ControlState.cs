using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class ControlState
    {

        public static void Main()
        {
            
            looping();
            conditional();
        }




        public static void looping()
        {
           
            Console.WriteLine("Looping --> foreach and for");
            int[] numbers1 = { 6, 4, 2, 8, 5 };
            int sum = 0;
            Console.Write("Array = ");
            foreach (int number in numbers1)
            {
                Console.Write(number + ",");

            }
            Console.WriteLine(" ");

            for (int i = 0; i < numbers1.Length; i++)
            {
                sum = sum + numbers1[i];
            }
            Console.WriteLine("Sum of the Array: " + sum);
            Console.WriteLine("------------------------");
        }

        public static void conditional()
        {
            int a = 10;
            int b = 20;
            int c = 30;
            Console.WriteLine("If and Else");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);

            if (a > b && a > c)
            {
                Console.WriteLine("A is greater");

            }
            else if (b > c)
            {
                Console.WriteLine("B is greater");
            }
            else
            {
                Console.WriteLine("C is greater");
            }
            Console.WriteLine("------------------------");

            Console.WriteLine("Swich Case");

            char ch;
            Console.WriteLine("Enter an alphabet");
            ch = Convert.ToChar(Console.ReadLine());


            switch (Char.ToLower(ch))
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
                    
            }
            Console.WriteLine("------------------------");
        }
    }
}


