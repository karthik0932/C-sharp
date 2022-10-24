using System;


namespace Practice
{
    class Program
    {
        public static void Main()
        {
            sum();
            Program m = new Program();
            m.multi();
        }

        public static void sum()
        {
            int x = 10;
            int y = 20;

            Console.WriteLine(x + y);
        }

        public void multi()
        {
            int a = 10;
            int b= 20;
            int c = 30;
            Console.WriteLine(a * b * c);
        }
    }
}
