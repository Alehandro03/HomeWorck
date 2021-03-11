using System;

namespace Massiv_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
              array[i] = random.Next(0, 100);
              Console.WriteLine(array[i] + "");
            }
            Console.WriteLine();

            int[] tmpArray = new int[15];

            for (int i = array.Length-1; i>=0; i--)
            {
              tmpArray[i] = array[array.Length-i-1];
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {  
                Console.WriteLine(tmpArray[i] + "");
            }
        }
    }
}
