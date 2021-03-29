using NUnit.Framework;
using Linked;
namespace LinkedList.Tests
{
    class LinkedTests
    {
        [TestCase(5, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5 })]

        public void AddTest(int value, int[] array, int[] expectedArray)
        {
            Linked actual = new Linked(array);
            Linked expected = new Linked(expectedArray);

            actual.Add(value);

            Assert.AreEqual(expected, actual);
        }


    }
}