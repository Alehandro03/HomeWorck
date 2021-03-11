using System;

namespace Massiv_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
             array[i] = random.Next(0, 101);
             Console.WriteLine(array[i] + "");
            }

            Console.WriteLine();

            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
              if (min > array[i])
              {
               min = array[i];
              }

            }
            Console.WriteLine($"Минимальное значение");
            Console.WriteLine(min);

        }
    }
}
