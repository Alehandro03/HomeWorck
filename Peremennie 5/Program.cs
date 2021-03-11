using System;

namespace Peremennie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 0;
            int y = 0;
            int x = 2;

            a = (y1 - y2) / (x1 - x2);
            b = y2 - a * x2;

            y = a*x + b;

            Console.WriteLine(y);


        }
    }
}
