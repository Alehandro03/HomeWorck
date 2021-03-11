using System;

namespace Peremennie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;

            c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);



        }
        
        //{int a;
         // Console.WriteLine("InPut a:");
           // a = int.Parse(Console.ReadLine());
       // int b;
       // Console.WriteLine("InPut b");
       //     b = int.Parse(Console.ReadLine());

      //  int tmp;
      //  tmp = a;
         //   a = b;
         //   b = tmp;
         //   Console.WriteLine("a=" + a);
          //  Console.WriteLine("b=" + b);
          // Console.ReadLine();
        //

        
    }
}
