using System;

namespace Vetvlenia_1
{
    class Program
    {
        static void Main(string[] args)
        //Пользователь вводит 2 числа (A и B). 
        //Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;

            if (a > b)
            {
                c = a + b;
            }
            if (a == b)
            {
                c = a * b;
            }
            if (a<b)
            {
                c = a - b;
            }

            Console.WriteLine(c);




        }
    }
}
