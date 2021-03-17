using System;

namespace Vetvlenia_2
{
    class Vetvlenia2
    {
        static void Main(string[] args)
        //Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int c = 0;

            
            if(x>=0 && y>=0)
            {
               Console.WriteLine( c = 1); 
            }
            if (x>0 && y<0)
            {
                Console.WriteLine(c = 2);
            }
            if (x<0 && y>0)
            {
                Console.WriteLine(c = 3);
            }
            if (x<0 && y<0)
            {
                Console.WriteLine(c = 4);
            }
        }
    }
}
