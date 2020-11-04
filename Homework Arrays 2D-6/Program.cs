﻿using System;
using System.Security.Cryptography.X509Certificates;
using Arrays2D;

namespace Homework_Arrays_2D_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Отразите массив относительно его главной диагонали");
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
                    Console.Write(string.Format("{0,4}", a[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("Отсортированный массив:");
            int[,] transporate = Arrays2D.Arrays2DMethods.TransporateArray(a);
            for (int i = 0; i < transporate.GetLength(0); i++)
            {
                for (int j = 0; j < transporate.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,4}", transporate[i,j]));
                }
                Console.WriteLine();
                
            }
        }
    }
}
