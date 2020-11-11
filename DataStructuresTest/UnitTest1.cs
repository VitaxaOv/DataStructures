using DataStructures;
using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    public class ArrayListTests
    {
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4,5 },5)]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4,6},6)]
        [TestCase(new int[] { }, new int[] { 1 },1)]
        [TestCase(new int[] { }, new int[] { -5 }, -5)]
        public void Push_BackTests(int[] array, int[] expArray,int value)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);
            actual.Push_Back(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 11,-22, 34, 45 }, new int[] {45,34,-22,11})]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] {4,3,2,1})]
        [TestCase(new int[] { }, new int[] {  })]
        [TestCase(new int[] {1,2 }, new int[] {2,1 })]
        public void ReverseTests(int[] array, int[] expArray)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);
            actual.Reverse();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 5,6 }, new int[] { 5,6})]
        [TestCase(new int[] { 1, 2, 3, 4,11,343 }, new int[] { 1, 2, 3, 4,11,343,-11,-12 }, new int[] {-11,-12 })]
        [TestCase(new int[] { }, new int[] {  }, new int[] { })]
        [TestCase(new int[] { }, new int[] { -5 },new int[] { -5})]
        public void Push_BackArrayTests(int[] array, int[] expArray, int[] arr)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);
            actual.Push_BackArray(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 5,1, 2, 3, 4 }, 5)]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 6,1, 2, 3, 4 }, 6)]
        [TestCase(new int[] { }, new int[] { 1 }, 1)]
        [TestCase(new int[] { }, new int[] { -5 }, -5)]
        public void Push_FrontTests(int[] array, int[] expArray, int value)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);
            actual.Push_Front(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 5,6,1, 2, 3, 4, }, new int[] { 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 11, 343 }, new int[] {-11,-12, 1, 2, 3, 4, 11, 343 }, new int[] { -11, -12 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { }, new int[] { -5 }, new int[] { -5 })]
        public void Push_FrontArrayTests(int[] array, int[] expArray, int[] arr)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);
            actual.Push_FrontArray(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 5,2, 3, 4 }, 1,5)]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 66,4 }, 3,66)]
        [TestCase(new int[] { }, new int[] { 1 }, 0,1)]
      
        public void AddElemTests(int[] array, int[] expArray, int index,int value)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);
            actual.AddElem(index,value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 1, 2, 3, 4, },0, new int[] { 5, 6 })]
        [TestCase(new int[] { 5, 2, 3, 4, 11, 343 }, new int[] {  5,2,3,-11,-12 , 4, 11, 343 }, 3,new int[] { -11, -12 })]
        [TestCase(new int[] { }, new int[] { -5 }, 0,new int[] { -5 })]
        public void AddArrTests(int[] array, int[] expArray,int index, int[] arr)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);
            actual.AddArr(index,arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3})]
        [TestCase(new int[] { 1, 2, 3, 4,2,5 }, new int[] { 1, 2, 3, 4, 2 })]
        [TestCase(new int[] { 5}, new int[] {  })]
        [TestCase(new int[] {2,2 }, new int[] { 2 })]
        public void Pop_BackTests(int[] array, int[] expArray)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);
            actual.PopBack();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 3,4 },1)]
        [TestCase(new int[] { 1, 2, 3, 4, 2, 5 }, new int[] { 4, 2,5 },3)]
        [TestCase(new int[] { 5 }, new int[] { })]
        [TestCase(new int[] { 2, 2 }, new int[] { 2 })]
        public void Pop_FrontTests(int[] array, int[] expArray,int number=1)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);
            actual.PopFront(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] {1, 2,3 }, 3,1)]
        [TestCase(new int[] { 1, 2, 3, 4, 2, 5 }, new int[] { 1,2,2,5},2,2)]
        [TestCase(new int[] { 1, 2, 3, 4, 2, 5 }, new int[] { 1, 2,3 }, 3, 3)]
        [TestCase(new int[] { 5 }, new int[] { },0,1)]
        [TestCase(new int[] { 2, 2 }, new int[] { 2 },1,1)]
        public void DeleteElemTests(int[] array, int[] expArray,int index, int number = 1)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);
            actual.DeleteElem(index,number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, 10)]
        public void SetByIndexNegativeTest(int[] array, int index)
        {
            ArrayMyList actual = new ArrayMyList(array);

            //Assert.Throws<IndexOutOfRangeException>(() => actual[index] = 0);

            try
            {
                actual[index] = 0;
            }
            catch (IndexOutOfRangeException)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
        [TestCase(new int[] { 1, 2, 3, 4 },0 , 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 2, 5 },1 , 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 2, 5 }, -1,10 )]
        public void FindIndexTests(int[] array, int expected,int number)
        {
            ArrayMyList List = new ArrayMyList(array);
            int actual=List.FindIndex(number);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 5, 10, 3, 4 }, new int[] { 3, 4, 5,10 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] {-5,-55,56 }, new int[] { -55,-5,56 })]
        public void ArraySortTests(int[] array, int[] expArray)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);
            actual.ArraySort();
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 5, 10, 3, 4 }, new int[] { 10,5,4,3})]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { -5, -55, 56 }, new int[] { 56,-5,-55 })]
        public void ArraySortReverseTests(int[] array, int[] expArray)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);
            actual.ArraySortReverse();
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 5, 10, 3, 4 },3)]
        [TestCase(new int[] { 1},1)]
        [TestCase(new int[] { -5, -55, 56 },-55)]
        public void FindMinTests(int[] array, int expected)
        {
           
            ArrayMyList actual = new ArrayMyList(array);
            
            Assert.AreEqual(expected, actual.FindMin());
        }
        [TestCase(new int[] { 5, 10, 3, 4 }, 10)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { -5, -55, 56 }, 56)]
        public void FindMaxTests(int[] array, int expected)
        {

            ArrayMyList actual = new ArrayMyList(array);

            Assert.AreEqual(expected, actual.FindMax());
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1,2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 1, 4 }, new int[] { 1,2,4 })]
        public void DeletePervTests(int[] array, int[] expArray)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);
            actual.DeletePerv();
            Assert.AreEqual(expected, actual);
        }
    }
}
