using System;

namespace Cikl_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            for (i = 1; i * i < a; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }

}
