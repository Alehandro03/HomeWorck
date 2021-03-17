using NUnit.Framework;

namespace Peremennie_.Tests
{
    public class ProgramTests
    {
        [TestCase(4,3,-29)]
        [TestCase(10, 20, 45)]
        [TestCase(8, 12, 46)]
        public void SolveEquation(int firstNumber, int secondNumber, int expected)
        {
            int actual = (int)Program.SolveEquation(firstNumber, secondNumber);


            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 12, 8)]
        [TestCase(10, 20, 10)]
        [TestCase(14, 12, 14)]

        public void ChangeVariables(int b, int c, int expected)
        {
            int actual = Program.ChangeVariables(b,c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 10, 2,-4)]
        [TestCase(10, 20, 10,-1)]
        [TestCase(2, 10, 20,5)]

        public void GetLinearEquation(double a, double b, double c, double expected)
        {
            double actual = Program.GetLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}