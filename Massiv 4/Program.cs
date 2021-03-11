using System;

namespace Massiv_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]array  =  new int[15];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
             array[i] = random.Next(0,100);
             Console.WriteLine(array[i] + "");
            }
            Console.WriteLine();

            int min = array[0];

            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
              if (min > array[i])
              {
               min = array[i];
               minIndex = i;
              }
            }
            
            Console.WriteLine($"Минимальный индекс");
            Console.WriteLine(minIndex);
        }
    }
}
