using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Inter
    {
        public int stdid;
        public string stdname;
        public string stddep;

        public void std_details(int id, string name, string dep)
        {
            stdid = id;
            stdname = name;
            stddep = dep;
            Console.WriteLine($"{stdid}:{stdname}:{stddep}");
        }
    }
    public class Inter_pub
    {
       public static void Main()
        {
            Inter inter = new Inter();
            inter.std_details(1013,"karthik","Developer");
        }
    }
}
