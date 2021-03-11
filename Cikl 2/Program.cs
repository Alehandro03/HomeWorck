using System;

namespace Cikl_2
{
    class Program
    {
        static void Main(string[] args)
        {          
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 1000; i++)
            {
               if (i % a == 0)
               {
                 Console.Write($"{i} ");
               }
            }
            

        }
    }
}
