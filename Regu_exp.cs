using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TE_CSharp
{
    
    internal class Regu_exp
    {
        public static void Main()
        {
            mobile();
        }

        public static void mobile()
        {
            Console.WriteLine("Mobile validation");
            Console.WriteLine("Enter the 10 digit mobile number");
            //string mobile = "(9/8/7)389674670"--> Ture otherwise false
            var mobile =(Console.ReadLine());
            var validate_mobile = Regex.IsMatch(mobile, @"^[789]\d{9}$");
            Console.WriteLine(validate_mobile);
        }

    }
}
