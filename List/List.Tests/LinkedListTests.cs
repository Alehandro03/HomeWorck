using NUnit.Framework;
using List;


namespace List.Tests
{
    class LinkedListTests
    {
        [TestCase(5, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5 })]
        public void AddTest(int value, int[] array, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(array);
            LinkedList expected = new LinkedList(expectedArray);

            actual.Add(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 2, new int[] { 2, 1, 2, 3 })]
        public void AddFirstTest(int[] actualAr, int value, int[] arExpected)
        {
            LinkedList actual = new LinkedList(actualAr);
            LinkedList expected = new LinkedList(arExpected);

            actual.AddFirst(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase( 6, 2, new int[] { 1, 4, 2, 5, 4 }, new int[] { 1, 4, 6, 2, 5, 4 })]
        public void AddByIndexTest(int index, int value,    int[] _array, int[] expectedE)
        {
            LinkedList actual = new LinkedList(_array);
            LinkedList expected = new LinkedList(expectedE);

            actual.AddByIndex(index ,value);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 4, 2, 5, 4 }, new int[] { 1, 4, 2, 5 })]
        public void RemoveLastTest(int[] tmpArray, int[] expectedE)
        {
            LinkedList actual = new LinkedList(tmpArray);
            LinkedList expected = new LinkedList(expectedE);

            actual.RemoveLast();



            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 4, 2, 5, 4 }, new int[] { 4, 2, 5, 4 })]
        public void RemoveFirstTest(int[] tmpArray, int[] expectedE)
        {
            LinkedList actual = new LinkedList(tmpArray);
            LinkedList expected = new LinkedList(expectedE);

            actual.RemoveFirst();

            Assert.AreEqual(expected, actual);

        }

        [TestCase(2, new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 4, 5 })]
        public void RemoveByIndexTest(int index, int[] array, int[] expectedArray)
        {
            LinkedList actual = new LinkedList(array);
            LinkedList expected = new LinkedList(expectedArray);

            actual.RemoveByIndex(index);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 4, 2, 5, 4 }, 2, new int[] { 1, 4, 2 })]

        public void RemoveLastNTest(int[] tmpArray, int n, int[] expectedE)
        {
            LinkedList actual = new LinkedList(tmpArray);
            LinkedList expected = new LinkedList(expectedE);

            actual.RemoveLastN(n);

            Assert.AreEqual(expected, actual);

        }
    }
}
