using System;

namespace Peremennie_
{

    public static class Program
    {
        

        private static void Main(string[] args)
        {
            ref int b =  ChangeVariables(10);
            Console.WriteLine(b);

            ref int c = ChangeVariables(5);
            Console.WriteLine(c);


        }

        public static double SolveEquation(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                throw new ArgumentException("Число А не может быть равно B");
            }
            else
            {
                double result = (5 * firstNumber + Math.Pow(secondNumber, 2)) / (secondNumber - firstNumber);
                return result;
            }

        }

        public static int ChangeVariables(ref int b,ref int c)
        {
            int a = b;
            b = c;
            c = a;                  
        }

        public static int[] SolveDivisionAndShowRemainder(int a, int b)
        {

            if (b == 0)
            {
                throw new DivideByZeroException("Второе число не может быть нулем.");
            }

            int result = a / b;
            int ostatok = a % b;

            return new int[] { result, ostatok };
        }

        public static double GetLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("a==0");
            }
            double x = (c - b) / a;
            return x;
        }

        public static string ShowLinearEquation(double x1, double x2, double y1, double y2)
        {
            double a = (y1 - y2) / (x1 - x2);
            double b = y2 - a * x2;
            return new string($"y= {a}x + {b}");
        }
    }
}
