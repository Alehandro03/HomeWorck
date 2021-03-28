using NUnit.Framework;
using List;

namespace List.Tests
{
    public class ArrayListTests
    {
        [TestCase(6, new int[] { 1, 4, 2, 5, 4 }, new int[] { 1, 4, 2, 5, 4, 6 })]
        public void AddTest(int value,int[]_array, int[] expectedE)
        {
            ArrayList actual = new ArrayList(_array);
            ArrayList expected = new ArrayList(expectedE);
            actual.Add(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase( 6, new int[] { 1, 4, 2, 5, 4 }, new int[] {6, 1, 4, 2, 5, 4 })]
        public void AddFirstTest(int value,int[]_array,int[] expectedE)
        {


            ArrayList actual = new ArrayList(_array);
            ArrayList expected = new ArrayList(expectedE);

            actual.AddFirst(value);

            Assert.AreEqual(expected, actual);

        }


        [TestCase(6,2, new int[] { 1, 4, 2, 5, 4 }, new int[] { 1, 4, 6, 2, 5, 4 })]
        public void AddByIndexTest(int value, int index, int[]_array,int[] expectedE )
        {
            ArrayList actual = new ArrayList(_array);
            ArrayList expected = new ArrayList(expectedE);

            actual.AddByIndex(value,index);
            
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 4, 2, 5, 4 }, new int[] { 1, 4, 2, 5})]
        public void RemoveLastTest(int[]tmpArray,int[]expectedE)
        {
            ArrayList actual = new ArrayList(tmpArray);
            ArrayList expected = new ArrayList(expectedE);

            actual.RemoveLast();



            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 4, 2, 5, 4 }, new int[] { 4, 2, 5, 4 })]
        public void RemoveFirstTest(int[]tmpArray,int[]expectedE)
        {
            ArrayList actual = new ArrayList(tmpArray);
            ArrayList expected = new ArrayList(expectedE);

            actual.RemoveFirst();

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 4, 2, 5, 4 },3, new int[] { 1, 4, 2, 4 })]
        public void RemoveByIndexTest(int[] tmpArray,int index, int[] expectedE)
        {
            ArrayList actual = new ArrayList(tmpArray);
            ArrayList expected = new ArrayList(expectedE);

            actual.RemoveByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 4, 2, 5, 4 }, 2, new int[] { 1, 4, 2 })]
       
        public void RemoveLastNTest(int[] tmpArray,int n, int[] expectedE)
        {
            ArrayList actual = new ArrayList(tmpArray);
            ArrayList expected = new ArrayList(expectedE);

            actual.RemoveLastN(n);

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 4, 2, 5, 4 }, 2, new int[] { 2, 5, 4 })]
        [TestCase(new int[] { 1, 4, 2, 5, 4 }, 3, new int[] { 5, 4 })]
        public void RemoveFirstNTest(int[] tmpArray, int n, int[] expectedE)
        {
            ArrayList actual = new ArrayList(tmpArray);
            ArrayList expected = new ArrayList(expectedE);

            actual.RemoveFirstN(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 4, 2, 5, 4 }, 2, new int[] { 1, 4, 2 })]
        [TestCase(new int[] { 1, 4, 2, 5, 4, 5, 7, 3, 7 }, 6, new int[] { 1, 4, 2, 5, 4, 5, 7 })]
        public void RemoveByIndexNTest(int[] tmpArray,int index, int[] expectedE)
        {
            ArrayList actual = new ArrayList(tmpArray);
            ArrayList expected = new ArrayList(expectedE);

            actual.RemoveByIndexN(index);

            Assert.AreEqual(expected, actual);
        }

       
       
        [TestCase(new int[] { 1, 4, 2, 5, 4 }, 2, new int[] { 1, 4, 2 , 5, 4})]
        public void GetByIndexTest(int[] tmpArray, int index, int[] expectedE )
        {
            ArrayList actual = new ArrayList(tmpArray);
            ArrayList expected = new ArrayList(expectedE);

            actual.GetByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        
        


        [TestCase(new int[] { 1, 4, 2, 5, 4 }, 2, 2)]
        public void GetIndexByValueTest(int[] tmpArray, int index, int expected)
        {
            ArrayList actualArray = new ArrayList(tmpArray);
            int actual = actualArray.GetIndexByValue(index);            
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 4, 2, 5, 4 }, new int[] { 4, 5, 2, 4, 1 })]
        public void ReverseTest(int[] tmpArray, int[] expectedE)
        {
            ArrayList actual = new ArrayList(tmpArray);
            ArrayList expected = new ArrayList(expectedE);

            actual.Reverse();

            Assert.AreEqual(expected, actual);
        }

        

         [TestCase(new int[] { 1, 4, 6, 2, 5, 4 }, 6)]
        public void MaxValueTest(int[] _array, int expected)
        {
            ArrayList tmpArray = new ArrayList(_array);

            int actual = tmpArray.MaxValue();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 4, 6, 2, 1, 5, 4 }, 1)]

        public void MinValueTest(int[] _array, int expected)
        {
            ArrayList tmpArray = new ArrayList(_array);

            int actual = tmpArray.MinValue();

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 4, 6, 2, 1, 5, 4 }, 1)]

        [TestCase(new int[] { 1, 5, 4, 10, 28, 11, 17 }, 4)]

        public void MaxIndexTest(int[] _array, int expected)
        {
            ArrayList tmpArray = new ArrayList(_array);

            int actual = tmpArray.MaxIndex();

            Assert.AreEqual(expected, actual);

        }


        [TestCase(new int[] { 4, 6, 2, 1, 5, 4 }, 3)]

        public void MinIndexTest(int[] _array, int expected)
        {
            ArrayList tmpArray = new ArrayList(_array);

            int actual = tmpArray.MinIndex();

            Assert.AreEqual(expected, actual);

        }


        [TestCase(new int[] { 4, 6, 2, 1, 5, 4 }, new int[] { 1, 2, 4, 4, 5, 6 })]

        public void SortAscendingTest(int[] tmpArray, int[] expectedE)
        {
            ArrayList actual = new ArrayList(tmpArray);
            ArrayList expected = new ArrayList(expectedE);

            actual.SortAscending();

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 4, 6, 2, 1, 5, 4 }, new int[] { 6, 5, 4, 4, 2, 1 })]

        public void SortDescendingTest(int[] tmpArray, int[] expectedE)
        {
            ArrayList actual = new ArrayList(tmpArray);
            ArrayList expected = new ArrayList(expectedE);

            actual.SortDescending();

            Assert.AreEqual(expected, actual);

        }


        [TestCase(5, new int[] { 3, 5, 6, 2, 5, 4 }, new int[] { 3, 6, 2, 5, 4 })]
        public void RemoveByValueFisrtTest(int value, int[] array, int[] expectedArray)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            actual.RemoveByValueFisrt(value);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(8, new int[] { 3, 8, 6, 4, 8, 5, 2, 8 }, new int[] { 3, 6, 4, 5, 2 }, 3)]
        public void RemoveByValueAllTest(int value, int[] array, int[] expectedArray, int expectedCount)
        {
            ArrayList actual = new ArrayList(array);
            ArrayList expected = new ArrayList(expectedArray);

            int actualCount = actual.RemoveByValueAll(value);

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedCount, actualCount);

        }

    }  
}