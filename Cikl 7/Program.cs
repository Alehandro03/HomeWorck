using System;

namespace Cikl_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            while ((a!=0) && (b!=0))
            {
                if(a>b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
        }
    }
}
