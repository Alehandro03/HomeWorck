using System;

namespace Massiv_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();

            for (int i= 0; i < array.Length; i++)
            {
                array[i] = random.Next(50);
                Console.WriteLine(array[i] + "");
            }
            Console.WriteLine();

            int sum = 0;
            int a = 0;

            for (int i = 0; i < array.Length; i++)
            {
              if(i%2!=0)
                {
                 a = i / i;
                 sum = (a + sum);     
                }
            }
            Console.WriteLine($"Колличество нечетных элементов массива");
            Console.WriteLine(sum);


        }
    }
}
