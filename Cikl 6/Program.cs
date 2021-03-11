using System;

namespace Cikl_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 1;
            int b = 1;

            for (int i = 1; i < n - 1; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine(c);

        }
    }
}
