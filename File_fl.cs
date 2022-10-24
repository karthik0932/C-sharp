using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class File_fl
    {
        public static void Main()
        {
            string path = @"C:\Users\ei13113\Desktop\karthik\Technical_Training\Others\Text1.txt";
            string[] content;
            content = File.ReadAllLines(path);
            Console.WriteLine("First line of Text1 file is");
            Console.WriteLine(content[0]);            
        }

    }
}
