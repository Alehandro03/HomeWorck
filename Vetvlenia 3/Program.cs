using System;

namespace Vetvlenia_3
{
    class Program
    {
        static void Main(string[] args)
        //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a>b & a>c & b>c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
            if (b>a && b>c && a>c)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
            }
            if (c>b && c>a && b>a)
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
            if (a>b && a>c && c>b)
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
    }
}
