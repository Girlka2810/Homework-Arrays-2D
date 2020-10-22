using System;

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
            int[,] a = new int[n, n1];
            Random r = new Random();
            int count = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    a[i, j] = r.Next(0, 10);
                }
            }
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                                     
                        Console.Write(string.Format("{0,4} ", a[i, j]));
                }
            Console.WriteLine();
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    bool left = j != 0 && a[i, j] > a[i, j - 1] || j == 0;
                    bool right = j != n1 - 1 && a[i, j] > a[i, j + 1] || j == n1-1;
                    bool up = i != 0 && a[i, j] > a[i - 1, j] || i == 0;
                    bool down = i != n - 1 && a[i, j] > a[i + 1, j] || i == n-1;
                    if (left && right && up && down)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Количество элементов: {count}");
        }

        }
    }




