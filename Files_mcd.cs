using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
  
    internal class Files_mcd
    {
        public  static void Main()
        {
            string source = @"C:\Users\ei13080\Desktop\Ujwala\Technical_Training\Others\Text1.txt";
            string target = @"C:\Users\ei13080\Desktop\Ujwala\Technical_Training\Files\Text1.txt";

            //File.Move(source,target);
            //File.Copy(target, source);
            File.Delete(target);
        }

    }
}
