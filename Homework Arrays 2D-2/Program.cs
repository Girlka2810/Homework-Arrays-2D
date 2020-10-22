using System;

namespace Homework_Arrays_2D_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Найти максимальный элемент массива");
            Console.WriteLine("Укажите количество переменных:");
            Console.Write("N=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("N1=");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n1];
            Random r = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = r.Next(-100, 100);

                }
            }
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {

                    //if (a[i, j] / 10 != 0)
                    {
                        Console.Write("  {0} ", a[i, j]);
                    }
                    //else 
                    //{
                    //    Console.Write("{ 0 } ", a[i, j]);
                    //}
                }
                Console.WriteLine();
            }

            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    if (max <= a[i, j])
                    {
                        max = a[i, j];
                    }
            }
            Console.WriteLine();
            Console.WriteLine($"Наибольший элемент массива: {max}");
        }
    }
}
