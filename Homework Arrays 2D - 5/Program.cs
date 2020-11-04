using System;
using Arrays2D;
namespace Homework_Arrays_2D___5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти количество элементов массива, " +
                "которые больше своих левого, правого, верхнего и нижнего соседа одновременно.");
            Console.WriteLine("Укажите количество переменных:");
            Console.Write("N=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("N1=");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int[,] a = Arrays2D.Arrays2DMethods.InputRandomArray2D(n, n1);
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                                     
                        Console.Write(string.Format("{0,4} ", a[i, j]));
                }
            Console.WriteLine();
            }
            int count = Arrays2D.Arrays2DMethods.FindQuantityOfElementsThatBiggerThanNeighbour2D(a);
            Console.WriteLine($"Количество элементов: {count}");
        }

        }
    }




