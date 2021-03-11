using System;

namespace Cikl_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа (A и B).
            // Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. 
            //(Учтите, что при вводе B может оказаться меньше A).
            Console.WriteLine($"Введите число А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите число Б");
            int b = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            int v = 0;
            int sum = 0;

            if (a<b)
            {
                n = a;
                v = b;
            }
            else
            {
                v = a;
                n = b;
            }

            for (int i = n; i < v; i++)
            {
                if (i % 7 == 0)
                {

                    sum = i + sum;

                }


            }
            Console.WriteLine($"Ваш ответ");
            Console.WriteLine(sum);
                

            
            
        }
    }
}
