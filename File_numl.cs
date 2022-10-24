using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class File_numl
    {
        public static void Main()
        {
            string path= @"C:\Users\ei13080\Desktop\Ujwala\Technical_Training\Others\Text1.txt";
            int count = File.ReadAllLines(path).Length;
            Console.WriteLine("Number of lines Text1 file: " + count);
        }
    }
}
