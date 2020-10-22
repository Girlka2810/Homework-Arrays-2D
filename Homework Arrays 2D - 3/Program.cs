using System;

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
                        {
                            Console.Write(string.Format("{0,3} ", a[i, j]));
                        }
                    }
                    Console.WriteLine();
                }

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
                Console.WriteLine();
                Console.WriteLine("Наименьший элемент массива: " + min);
                Console.WriteLine("Индекс наименьшего элемента массива: (" + indexI + ", " + indexJ + ")");
            }
        }
    }
}
