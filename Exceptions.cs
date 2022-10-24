using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class ExpDemo
    {
        /// <summary>
        /// Multiple catch
        /// </summary>
        public void Multicatch()
        {
            int[] array1 = { 10, 2, 4, 8, 3, 8 };
            int[] array2 = { 5, 1, 0, 16, 3 };
            for (int i = 0; i < array1.Length; i++)
            {
                try
                {
                    Console.WriteLine(array1[i] / array2[i]);
                }

                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                   
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                    
                }

               
            }

        }
    }
    /// <summary>
    /// Propreties 
    /// </summary>
    public class Prop
    {
        float ans;
        public void Calcu(int a, int b)
        {
            try
            {
                ans = a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("---------------display Proprties of exceptions-------- ");

                Console.WriteLine(e.StackTrace);
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(e.ToString());
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(e.Data);
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(e.TargetSite);
                Console.WriteLine("-----------------------------------------------------------");
            }
            finally
            {
                Console.WriteLine("Proceed");
            }

        }

        
    }
    internal class Exceptions
    {
        public static void Main()
        {
            ExpDemo ex = new ExpDemo();
            ex.Multicatch();
          
            Prop prop = new Prop();
            prop.Calcu(1, 0);
        }
      
    }
}
