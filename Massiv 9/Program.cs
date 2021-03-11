using System;

namespace Massiv_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.WriteLine(array[i] + "");
            }
            Console.WriteLine();

            

            for (int i = 0; i < array.Length-1; i++)
            {
                int indexOfMax = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[indexOfMax] < array[j])
                    {
                        indexOfMax = j;
                    }
                }

                int tmp = array[i];
                array[i] = array[indexOfMax];
                array[indexOfMax] = tmp;

                Console.WriteLine(array[indexOfMax]);
            }

            Console.WriteLine();
            




        }
    }
}
