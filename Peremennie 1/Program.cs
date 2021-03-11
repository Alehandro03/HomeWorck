using System;

namespace Peremennie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;

            c = (5 * a + b * b) / (b - a);
            Console.WriteLine(c);



        }
    }
}
