using System;

namespace Cikl_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int left = 0;
            int right = a;
            int middle = (left+right)/2;
            
            while (middle * middle * middle!= a)
            {
                if ( middle > a)
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
            }
            middle = (left + right) / 2;
            Console.WriteLine(middle);
        }
        

         
    }
}
