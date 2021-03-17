using System;

namespace Massiv_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
             array[i] = random.Next(0, 101);
             Console.WriteLine(array[i] + "");

            }
            Console.WriteLine();

            int max = array[0];
            

            for (int i = 1; i < array.Length; i++)
            {
              if (max < array[i])
              {
               max = array[i];  
              }

            }
            Console.WriteLine($"Максимальное значение");
            Console.WriteLine(max);
            ;
        }
    }
}
