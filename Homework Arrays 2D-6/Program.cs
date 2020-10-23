using System;
using System.Security.Cryptography.X509Certificates;

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
            int[,] a = new int[n, n1];
            Random r = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    a[i, j] = r.Next(1, 99);
                }
            }
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
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        int temp = a[i, j];
                        a[i, j] = a[j, i];
                        a[j, i] = temp;
                    }
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,3}", a[i, j]));
                }
                Console.WriteLine();
                
            }
        }
    }
}
