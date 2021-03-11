using System;

namespace Massiv_5
{
    class Program
    {
        static void Main(string[] args)
        {
             
            int [] array = new int[10];
            Random random = new Random();

            for (int i=0; i<array.Length;i++)
            {
             array[i] = random.Next(0, 50);
             Console.WriteLine(array[i] + "");               
            }

            int sum = 0;
            

            for (int i = 1; i < array.Length; i++)
            { 
              if (i%2!=0)
              {
               sum = array[i]+sum;
              }  
              Console.WriteLine();
            }
            Console.WriteLine($"Сумма равна");
            Console.WriteLine(sum);
        }
    }
}
