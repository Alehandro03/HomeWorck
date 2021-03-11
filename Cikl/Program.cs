using System;

namespace Cikl
{
    class Program
    {
        static void Main(string[] args)
            // y = n*n*n; чему равен n???
        {
            //int y = Convert.ToInt32(Console.ReadLine());

            //int l = 0;
           // int r = y;
            //int m = r;
            

           // while ( y != m*m*m)
           // {
           //     if (m*m*m>y)
            //    {
            //        r = m;
            //    }
             //   else
            //    {
           //         l = m;
            //    }

            //    m = (l + r) / 2;
           // }

           

           // Console.WriteLine(m);

             
            
            int a = Convert.ToInt32(Console.ReadLine());
           
            int b = Convert.ToInt32(Console.ReadLine());

            int c = 0;

            if(b == 0)
            {
                c = 1;
                Console.WriteLine($"{a} ^ {b} = {c}");
            }
            if(b > 0)
            {
                c = a;
                for (int i = 1; i < b; i++)
                {
                    c *= a;
                }
                Console.WriteLine($"{a} ^ {b} = {c}");
            }
            if (b < 0)
            {
                c = a;
                for (int i = 1; i < Math.Abs(b); i++)
                {
                    c *= a;
                }
                Console.WriteLine($"{a} ^ {b} = 1/{c}");
            }

        }
    }
}
