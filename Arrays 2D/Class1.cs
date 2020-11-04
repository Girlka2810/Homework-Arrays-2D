using System;
using System.Dynamic;
using System.Globalization;
using System.Threading;

namespace Arrays2D
{
    public class Arrays2DMethods
    {
        public static int[,] InputRandomArray2D(int n, int n1)
        {
            int[,] array = new int[n, n1];
            Random r = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(0, 100);
                }
            }
            return array;
        }
        public static int FindMinElemOfArr2D(int[,] arr)
        {
            int[,] a = new int[arr.GetLength(1), arr.GetLength(0)];
            Array.Copy(arr, a, arr.Length);
            int min = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    if (min >= a[i, j])
                    {
                        min = a[i, j];
                    }
            }
            return min;
        }
        public static int FindMaxElemOfArr2D(int[,] arr)
        {
            int[,] a = new int[arr.GetLength(1), arr.GetLength(0)];
            Array.Copy(arr, a, arr.Length);
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    if (max <= a[i, j])
                    {
                        max = a[i, j];
                    }
            }
            return max;
        }
        public static int[] FindIndexOfMinElem2D(int[,] a)
        {
            int min = a[0, 0];
            int indexI = 0;
            int indexJ = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)

                    if (min >= a[i, j])
                    {
                        min = a[i, j];
                        indexI = i;
                        indexJ = j;
                    }
            }
            int[] ar = new int[2] { indexI, indexJ };
            return ar;
        }
        public static int[] FindIndexOfMaxElem2D(int[,] a)
        {
            int max = a[0, 0];
            int indexI = 0;
            int indexJ = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    if (max <= a[i, j])
                    {
                        max = a[i, j];
                        indexI = i;
                        indexJ = j;
                    }
            }
            int[] ar = new int[2] { indexI, indexJ };
            return ar;
        }
        public static int FindQuantityOfElementsThatBiggerThanNeighbour2D(int[,] a)
        {
            int n = a.GetLength(0);
                int n1= a.GetLength(1);
            int count = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    bool left = j != 0 && a[i, j] > a[i, j - 1] || j == 0;
                    bool right = j != n1 - 1 && a[i, j] > a[i, j + 1] || j == n1 - 1;
                    bool up = i != 0 && a[i, j] > a[i - 1, j] || i == 0;
                    bool down = i != n - 1 && a[i, j] > a[i + 1, j] || i == n - 1;
                    if (left && right && up && down)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static int[,] TransporateArray(int[,] a)
        {
            int[,] b = new int[a.GetLength(1), a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[j, i] = a[i, j];
                }
            }
            return b;
        }
    }
}
        
