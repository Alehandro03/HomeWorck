using NUnit.Framework;

namespace Cycle.Tests
{
    public static class CycleTests
    {
        [TestCase(5,8,390625)]
        [TestCase(2,2,4)]
        [TestCase(3,3,27)]
        [TestCase(5,5,3125)]

        public static void TestedTest(int a, int b,int expected)
        {
            int actual =  Cycle.Tested(a, b);

            Assert.AreEqual(expected, actual);

        }

        
        
        [TestCase(10, 10, 20)]
        [TestCase(10, 10, 20)]
        [TestCase(10, 10, 20)]

        public static void Tested2Test(int a, int expected)
        {
            int actual = Cycle.Tested2(a);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(10, 1, 2)]

        public static void Tested3Test(int a, int expected)
        {
            int actual = Cycle.Tested3(a);

            Assert.AreEqual(expected, actual);

        }
    }
}