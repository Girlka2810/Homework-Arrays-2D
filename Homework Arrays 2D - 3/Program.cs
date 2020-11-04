﻿using System;
using Arrays2D;
namespace Homework_Arrays_2D___3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Найти индекс наименьшего элемента массива");
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
                        {
                            Console.Write(string.Format("{0,3} ", a[i, j]));
                        }
                    }
                    Console.WriteLine();
                }

                int min = Arrays2D.Arrays2DMethods.FindMinElemOfArr2D(a);
                int[] index = Arrays2D.Arrays2DMethods.FindIndexOfMinElem2D(a);
                Console.WriteLine();
                Console.WriteLine("Наименьший элемент массива: " + min);
                Console.Write("Индекс наименьшего элемента массива:");
                Console.WriteLine(String.Join(", ", index));

            }
        }
    }
}
