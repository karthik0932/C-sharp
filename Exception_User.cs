using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Age : Exception
    {
        public Age(string message) : base(message)
        {

        }
    }
    internal class Exception_User
    {
        public static void Main()
        {
            int age;
            try
            {
                Console.WriteLine("Enter the Current age");
                age = Convert.ToInt32(Console.ReadLine());
                if(age>22)
                {
                    Console.WriteLine(("Adult"));
                }
                else
                {
                    Console.WriteLine("Below 22");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
