using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public delegate void DelegatesDelegate(int id, string name);

    public delegate void DelegatesDelegate1(int id, string name);
    public class Details
    {
        public void Getdetails(int id, string name)
        {
            Console.WriteLine($"Details:{id}:{name}");
        }
        public void Getdetails1(int id, string name)
        {
            Console.WriteLine($"Details-1:{id}:{name}");
        }

    }
    internal class Delegates
    {
        public static void Main()
        {
            //instance for class
            Details details = new Details();
            // call the delegate using a instance through a instance of a class
            // DelegatesDelegate del = details.Getdetails;
            //del = details.Getdetails1;
            //del(1001, "karthik");
            //del(1002,"nikki");
            DelegatesDelegate1 del1 = details.Getdetails;
            del1 += details.Getdetails1;
            del1(1999, "Pushpa");


        }
      
        
    }

}
