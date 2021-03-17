using System;

namespace Massiv_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();

            for (int i = 0; i< array.Length;i++)
            {
             array[i] = random.Next(100);
             Console.WriteLine(array[i] + "");
            }
            Console.WriteLine();

            int max = array[0];
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
              if (max < array[i])
              {
               max = array[i];
               maxIndex = i;
              }
            }
            
            Console.WriteLine($"Максимальное значение индекса");
            Console.WriteLine(maxIndex);
        }
    }
}
