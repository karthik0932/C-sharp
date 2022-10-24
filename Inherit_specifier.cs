using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Bonus
    {
        protected int bonus;
        
    }

    public class Staff:Bonus

    {
        protected int salary = 50000;
        protected void Getbonus1()
        {
            Console.WriteLine($"Bonus Caluculation for Staff with Salary {salary} is : " );
            bonus = 3* salary;
            Console.WriteLine(bonus);
            
        }
    }

    public class Nonstaff:Staff
    {
        protected int salary = 30000;
        public void Getbonus2()
        {
            
            Console.WriteLine($"Bonus Caluculation for NonStaff with Salary {salary} is : ");
            bonus = 2 * salary;
            Console.WriteLine(bonus);
            Getbonus1();

        }

    }

    internal class Inherit_specifier
    {
        public static void Main()
        {
            Staff s = new Staff();
            //s.Getbonus1();

            Nonstaff n = new Nonstaff();
            n.Getbonus2();
        }
    }
}
