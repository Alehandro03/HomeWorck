using System;

namespace Cycle
{
    public static class Cycle
    {
       
        public static void Main(string[] args)
        {
            int i = Tested3(1);
            Console.WriteLine(i);

        }

        public static int Tested(int a, int b)
        {

            int result = 0;

            if (b == 0)
            {
                result = 1;
                Console.WriteLine($"{a} ^ {b} = {result}");

            }
            if (b > 0)
            {
                result = a;
                for (int i = 1; i < b; i++)
                {
                    result *= a;
                }
                Console.WriteLine($"{a} ^ {b} = {result}");
            }
            if (b < 0)
            {
                result = a;
                for (int i = 1; i < Math.Abs(b); i++)
                {
                    result *= a;
                }
                Console.WriteLine($"{a} ^ {b} = 1/{result}");

            }
            return result;

        }

        public static int Tested2(int a)
        {
            
            for (int i = 1; i <= 50; i++)
            {
                if (i % a == 0)
                {
                    Console.Write($"{i} ");
                }

            }
            return i;
        }

        public static int Tested3(int a)
        {
            int i = 0;
            for ( i = 1; i * i < a; i++)
            {
                Console.Write($"{i} ");
            }
            return i;
        }

        public static int Tested4(int a)
        {
            //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
            int b = 0;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    b = i;
                }
            }

            return b;

        }

        public static int Tested5(int a, int b)
        {
            //Пользователь вводит 2 числа (A и B).
            // Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. 
            //(Учтите, что при вводе B может оказаться меньше A).

            int n = 0;
            int v = 0;
            int sum = 0;

            if (a < b)
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
            return sum;
        }

        public static int Tested6(int n)
        {
            int a = 1;
            int c = 1;
            int b = 1;

            for (int i = 1; i < n - 1; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;

        }

        public static double Tested7(double a, double b)
        {

            while ((a != 0) && (b != 0))
            {

                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a;
           
        }
    }
}
