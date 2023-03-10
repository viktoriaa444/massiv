using System;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        //  (1.11) Даны вещественные числа. Найти площадь пятиугольника, вершины которого имеют координаты 

        Console.WriteLine("Введите x1");
        int x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите y1");
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите x2");
        int x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите y2");
        int y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите x3");
        int x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите y3");
        int y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите x4");
        int x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите y4");
        int y4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите x5");
        int x5 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите y5");
        int y5 = Convert.ToInt32(Console.ReadLine());

        Point A = new Point() { X = x1, Y = y1 };
        Point B = new Point() { X = x2, Y = y2 };
        Point C = new Point() { X = x3, Y = y3 };
        Point D = new Point() { X = x4, Y = y4 };
        Point E = new Point() { X = x5, Y = y5 };


        double trg (Point n, Point z, Point m)
        {
            object ZM = Point.Subtract((Point)z, (Size)(Point)m);
            double N = ZM.Length;

            object ZN = Point.Subtract((Point)z, (Size)(Point)n);
            double Z = ZN.Length;

            object NM = Point.Subtract((Point)n, (Size)(Point)m);
            double M = NM.Length;

            double p = Math.Abs((n + z + m) / 2);  //полупериметр
            if (n < p && p > z && p > m)  //если полупериметр больше длины отрезков
            {
                double pp = Math.Sqrt(p * (p - n) * (p - z) * (p - m));  //находим площадь треугольника по формуле
                Console.WriteLine($"Площадь треугольник с длинами:{n} , {z} и {m} равна {pp},а полупериметр {p} ");
                return pp;
            }
            else
            {
                return 0; //так не бывает 
            }
        }

        double i1 = trg(A, B, C);  //значение площади треугольника
        double i2 = trg(B, C, D);
        double i3 = trg(B, D, E);
        if (0 < i1 && i2 > 0 && i3 > 0)  //если площади больше 0
        {
            double res = i1 + i2 + i3;  //вычисление площади многоугольника
            Console.WriteLine($"Площадь пятиугольника равна {res}");
        }
        else
        {
            Console.WriteLine("Такого многоугольника не существует");
        }




    }
}
