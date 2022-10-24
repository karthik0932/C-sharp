using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class employee
    {
        public static void Main()
        {
            employee dis = new employee();
            dis.detail(101,"Ujwala", "Developer",21);

        }
       
        public void  detail(int id, string name, string dep,int age)
        {
            Console.WriteLine("Hello!!");
            Console.WriteLine($"My name is {name},I am {age} years old."); 
            Console.WriteLine($"I am working as {dep} and my office ID is {id}.");
        }
       
    }

}
