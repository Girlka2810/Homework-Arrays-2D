using NUnit.Framework;
using Arrays2D;
using System;
namespace Homework_Array_2D_Tests
{
    public class Arryy2DTests
    {
        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(3,3)]
        [TestCase(4,4)]
        public void FindMinElemOfArr2DTests(int Array2DMock,int ExpectedMinMock)
        {
            int expected = GetExpectedMinMock(ExpectedMinMock);
            int[,] arr = GetArray2DMock(Array2DMock);
            int actual = Arrays2D.Arrays2DMethods.FindMinElemOfArr2D(arr);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        public void FindMaxElemOfArr2DTests(int Array2DMock, int ExpectedMaxMock)
        {
            int expected = GetExpectedMaxMock(ExpectedMaxMock);
            int[,] arr = GetArray2DMock(Array2DMock);
            int actual = Arrays2D.Arrays2DMethods.FindMaxElemOfArr2D(arr);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        public void FindIndexOfMinElem2DTests(int Array2DMock, int ExpectedMinIndexMock)
        {
            int[] expected = GetExpectedMinIndexMock(ExpectedMinIndexMock);
            int[,] arr = GetArray2DMock(Array2DMock);
            int[] actual = Arrays2D.Arrays2DMethods.FindIndexOfMinElem2D(arr);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        public void FindIndexOfMaxElem2DTests(int Array2DMock, int ExpectedMaxIndexMock)
        {
            int[] expected = GetExpectedMaxIndexMock(ExpectedMaxIndexMock);
            int[,] arr = GetArray2DMock(Array2DMock);
            int[] actual = Arrays2D.Arrays2DMethods.FindIndexOfMaxElem2D(arr);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        public void FindQuantityOfElementsThatBiggerThanNeighbour2DTests(int Array2DMock, int ExpectedQuantityMock)
        {
            int expected = GetExpectedQuantityMock(ExpectedQuantityMock);
            int[,] arr = GetArray2DMock(Array2DMock);
            int actual = Arrays2D.Arrays2DMethods.FindQuantityOfElementsThatBiggerThanNeighbour2D(arr);
            Assert.AreEqual(actual, expected);
        }
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]
        public void TransporateArrayTests(int Array2DMock, int ExpectedQuantityMock)
        {
            int[,] expected = GetExpectedTransporateMock(ExpectedQuantityMock);
            int[,] arr = GetArray2DMock(Array2DMock);
            int[,] actual = Arrays2D.Arrays2DMethods.TransporateArray(arr);
            Assert.AreEqual(actual, expected);
        }
        public int[,] GetArray2DMock(int n)
        {
            int[,] arr;
            switch (n)
            {
                case 1:
                    arr = new int[,] { { 10, 2, 3 }, { 4, 5, 6 }, { 100, 45, 12 } };
                    return arr;
                case 2:
                    arr = new int[,] { { -10, 289, 233 }, { 14, 455, 26 } };
                    return arr;
                case 3:
                    arr = new int[,] { { -45, 21 }, { -4587, 564 } };
                    return arr;
                case 4:
                    arr = new int[,] { { 0, 12 }, { 454, 788 }, { 99, 1 }, { 567, -12020 } };
                    return arr;
                default:
                    throw new Exception();
            }
        }
        public int GetExpectedMinMock(int a)
        {
            switch(a)
            {
                case 1:
                    return 2;
                case 2:
                    return -10;
                case 3:
                    return -4587;
                case 4:
                    return -12020;
                default:
                    throw new Exception();
            }
        }
        public int GetExpectedMaxMock(int a)
        {
            switch (a)
            {
                case 1:
                    return 100;
                case 2:
                    return 455;
                case 3:
                    return 564;
                case 4:
                    return 788;
                default:
                    throw new Exception();
            }
        }
       
        public int[] GetExpectedMinIndexMock(int a)
        {
            int[] arr;
            switch (a)
            {
                case 1:
                    arr = new int[2] { 0, 1 } ;
                    return arr;
                case 2:
                    arr = new int[2] { 0, 0 };
                    return arr;
                case 3:
                    arr = new int[2] { 1,0 };
                    return arr;
                case 4:
                    arr = new int[2] { 3, 1 };
                    return arr;
                default:
                    throw new Exception();
            }
        }
        public int[] GetExpectedMaxIndexMock(int a)
        {
            int[] arr;
            switch (a)
            {
                case 1:
                    arr = new int[2] { 2, 0 };
                    return arr;
                case 2:
                    arr = new int[2] { 1, 1 };
                    return arr;
                case 3:
                    arr = new int[2] { 1, 1 };
                    return arr;
                case 4:
                    arr = new int[2] { 1, 1 };
                    return arr;
                default:
                    throw new Exception();
            }
        }
        public int GetExpectedQuantityMock(int a)
        {
            switch (a)
            {
                case 1:
                    return 2;
                case 2:
                    return 1;
                case 3:
                    return 1;
                case 4:
                    return 2;
                default:
                    throw new Exception();
            }
        }
        public int[,] GetExpectedTransporateMock(int a)
        {
            int[,] arr;
            switch (a)
            {
                case 1:
                    arr = new int[,] { { 10, 4, 100 }, { 2, 5, 45 }, { 3, 6, 12 } };
                    return arr;
                case 2:
                    arr = new int[,] { { -10, 14 },{289, 455 }, { 233, 26 } };
                    return arr;
                case 3:
                    arr = new int[,] { { -45, -4587 }, { 21, 564 } }; ;
                    return arr;
                case 4:
                    arr = new int[,] { { 0, 454,99,567}, { 12,788,1, -12020 } };
                    return arr;
                default:
                    throw new Exception();
            }
        }
        }

}