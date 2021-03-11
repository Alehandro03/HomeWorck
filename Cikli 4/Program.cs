using System;

namespace Cikli_4
{
    class Program
    {
        static void Main(string[] args)
        //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
        {
            int a = Convert.ToInt32(Console.ReadLine());

            int b = 0;

            

            for ( int i =1; i<a; i++)
            {
                if (a % i == 0)

                    b = i;
                

                
            }

            Console.WriteLine(b);

        }
        

        
    }
}
