using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public delegate void Bank(string name, float i);
    public delegate void Bank1(string name, float i);
    public delegate void Bank2(string name, float i);
    public class Bank_details
    {
        public int p;
        public int t;
        public Bank_details()
        {
            Console.WriteLine("Enter the Principal Amount");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Time in Year");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------");
        }
        /// <summary>
        /// To calculate the simple intrest formula is  
        /// simple intrest=(intrest rate*principal amount* time*365)/100
        /// </summary>
        /// <param name="name"></param>
        /// <param name="i"></param>
        public void GetSbi(string name, float i)
        { 
            float simple_int = (i* p * t*365) / 100;
            Console.WriteLine($"SBI Intrest rate is: {i}%");
            Console.WriteLine($"Simple Intrest: Rs.{simple_int}/-");
            Console.WriteLine("---------------------------------------------------");
        }
        public void GetHdfc(string name, float i)
        {

            float simple_int = (i * p * t * 365) / 100;
            Console.WriteLine($"HDFC Bank Intrest rate is: {i}%");
            Console.WriteLine($"Simple Intrest: Rs.{simple_int}/-");
            Console.WriteLine("---------------------------------------------------");
        }
        public void GetKmb(string name, float i)
        {
            float simple_int = (i * p * t * 365) / 100;
            Console.WriteLine($"Kotak Mahindra Bank Intrest rate is: {i}%");
            Console.WriteLine($"Simple Intrest: Rs.{simple_int}/-");
            Console.WriteLine("---------------------------------------------------");
        }
        public void GetAxis(string name, float i)
        {
            float simple_int = (i * p * t * 365) / 100;
            Console.WriteLine($"Axis Bank Intrest rate is: {i}%");
            Console.WriteLine($"Simple Intrest: Rs.{simple_int}/-");
            Console.WriteLine("---------------------------------------------------");
        }
        public void GetIcici(string name, float i)
        {
            float simple_int = (i * p * t * 365) / 100;
            Console.WriteLine($"ICICI Bank Intrest rate is: {i}%");
            Console.WriteLine($"Simple Intrest: Rs.{simple_int}/-");
            Console.WriteLine("---------------------------------------------------");
        }
    }
    public class Dele_Intrest
    {
        public static void Main()
        {
            Bank_details bank_Details = new Bank_details();
            Bank bank = bank_Details.GetSbi;
            bank("sbi", 2.70f);
            Bank1 bank1=bank_Details.GetHdfc; 
            bank1+=bank_Details.GetAxis;
            bank1+= bank_Details.GetIcici;
            bank1("Kotak", 3.25f);
            Bank2 bank2=bank_Details.GetKmb;
            bank2("Mahindra", 3.50f);

        }
    }
}
