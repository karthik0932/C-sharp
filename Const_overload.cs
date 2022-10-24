using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{

    public class add
    {
        public add(int a, int b)
        {
            Console.WriteLine($"Out put of add in int: {a+b}");
        }
        public add(float a, float b)
        {
            Console.WriteLine($"Out put of add in float: {a+b}");
        }
        public add(string a,string b)
        {
           
            Console.WriteLine($"Out put of add in string: {a+b}");
        }
    }
    internal class Const_overload
    {
        public static void Main()
        {
            add ad = new add(1, 2);
            add ad1 = new add(1.45f, 2.30f);
            add ad2 = new add("1", "2");
        }
       
    }
}
