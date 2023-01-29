using System;
using System.Data;
using System.IO.IsolatedStorage;

class Program
{
    static void Main(string[] args)
    {
        // Значения элементов двумерного массива из m строк и n столбцов.скопировать в одномерный массив размером m n
        // Копирование проводить:
        // по строкам начиная с первой(а в ней — с крайнего левого элемента)
        Console.WriteLine("Введите значение n");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение m");
        int m = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();

        int[,] array = new int[n, m];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(100);
            }
        }
        Console.WriteLine("двумерный массив:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
        int q = n * m;
        int[] array1 = new int[q];
        Console.WriteLine("одномерный массив:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int e = 0; e < array1.GetLength(0); e++)
                {
                    array1[e] = array[i, j];
                    Console.Write($"{array1[e]}  ");
                    break;


                }
            }
        }
    }
}