using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Collection_HastDict
    {
        /// <summary>
        /// Collection class type Dictionary
        /// </summary>
        public static void demo()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Python");
            dict.Add(2, "C++");
            dict.Add(3, "VLSI");
            foreach(var obj in dict)
            {
                Console.WriteLine(obj);
            }
            //Console.WriteLine("Key value of dict: " + dict[0]);//Leading to an error
            Console.WriteLine("Key value of dict[1]: " + dict[1]);
        }
        /// <summary>
        /// Collection class type Hashtable
        /// </summary>
        public static void demo1()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Wave Theory");
            
            ht.Add(2, "Direct Current");
            ht.Add(3, "Electronics");
            //foreach(var obj in ht)
            //{
            // Console.WriteLine(obj);
            //}
            //we can't print the value of Hashtable directly using foreach, we should use ICollection like below method
            ICollection key= ht.Keys;
            foreach (var obj in key)
            {
                Console.WriteLine(ht[obj]);
            }
            Console.WriteLine("Key value of ht[0]: "+ ht[0]);
            Console.WriteLine("Key value of ht[1]: " + ht[1]);
        }
        public static void Main()
        {
            demo();
            Console.WriteLine("------------------------------------");
            demo1();
        }
    }
}
