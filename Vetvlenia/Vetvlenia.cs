using System;
using System.Collections.Generic;
using System.Text;

namespace Vetvlenia_1
{
    class Vetvlenia
    {
        public static int Main(string[] args)
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
            if (a < b)
            {
                c = a - b;
            }

            return c;






        }

        public static int Fourth(string[] args)
        //Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int c = 0;


            if (x >= 0 && y >= 0)
            {
                Console.WriteLine(c = 1);
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine(c = 2);
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine(c = 3);
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine(c = 4);
            }
        }

        public static void Main(string[] args)
        //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b & a > c & b > c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            if (b > a && b > c && a > c)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
            if (c > b && c > a && b > a)
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
            if (a > b && a > c && c > b)
            {
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);

            }
            if (b > c && b > a && c > a)
            {
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);

            }
            if (c > b && c > a && a > b)
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);

            }
        }
        public static void Main(string[] args)
        //Пользователь вводит 3 числа (A, B и С). 

        {
            int a = Convert.ToInt32(Console.ReadLine());
            string a1 = $"Одиннадцать";
            string a2 = $"Двенадцать";
            string a3 = $"Тринадцать";
            string a4 = $"Четырнадцать";
            string a5 = $"Пятнадцать";
            string a6 = $"Шустнадцать";
            string a7 = $"Семнадцать";
            string a8 = $"Восемнадцать";
            string a9 = $"Девятнадцать";
            string a10 = $"Двадцать";

            a = Convert.ToInt32(a1);
            a = Convert.ToInt32(a2);
            a = Convert.ToInt32(a3);
            a = Convert.ToInt32(a4);
            a = Convert.ToInt32(a5);
            a = Convert.ToInt32(a6);
            a = Convert.ToInt32(a7);
            a = Convert.ToInt32(a8);
            a = Convert.ToInt32(a9);
            a = Convert.ToInt32(a10);

            Console.WriteLine(a);

        }

    }
}