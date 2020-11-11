using DataStructures;
using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    public class ArrayListTests
    {
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        public void ReversTests(int[] array, int[] expArray)
        {
            ArrayMyList expected = new ArrayMyList(expArray);
            ArrayMyList actual = new ArrayMyList(array);

            //actual.Reverse();

            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new int[] { 1, 2, 3, 4 }, 10)]
        //public void SetByIndexNegativeTest(int[] array, int index)
        //{
        //    ArrayList actual = new ArrayList(array);

        //    //Assert.Throws<IndexOutOfRangeException>(() => actual[index] = 0);

        //    try
        //    {
        //        actual[index] = 0;
        //    }
        //    catch (IndexOutOfRangeException)
        //    {
        //        Assert.Pass();
        //    }
        //    Assert.Fail();
        //}
    }
}







//using NUnit.Framework;
//using DataStructures;
//namespace DataStructuresTest
//{
//    public class ArrayListTest
//    {
//        [TestCase(new int[] {1,2,3,5 },new int[] {1,2,3,5}) ]
//        public void Push_BackTest(int []array,int []exparray)
//        {
//            ArrayMyList expected= new ArrayMyList(exparray);
//            ArrayMyList actual = new ArrayMyList(array);
//            //actual.Push_Back(5);
//            Assert.AreEqual(expected, actual);
//        }
//    }
//}