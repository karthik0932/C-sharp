using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Out_keyword
    {
        public static void Main()
        {
            int id;
            string name;
            string dep;
            details(out id, out name, out dep);
            Console.WriteLine("My Name is {1}, I am a student of {2} and my ID is {0}", id, name, dep);
        }
      public static void details(out int sid, out string sname, out string sdep)
        {
            sid = 1001;
            sname = "karthik";
            sdep = ".NET Frame work";

        }
    }
}
