using System;
using System.Data;
using System.IO.IsolatedStorage;

class Program
{
    static void Main(string[] args)
    {
        //  (1.16) Даны вещественные числа. Найти площадь пятиугольника, вершины которого имеют координаты 

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

        double b = Math.Abs(((x2 - x1) ^ 2 + (y2 - y1) ^ 2) ^ (1 / 2));
        double a = Math.Abs(((x3 - x2) ^ 2 + (y3 - y2) ^ 2) ^ (1 / 2));
        double e = Math.Abs(((x4 - x3) ^ 2 + (y4 - y3) ^ 2) ^ (1 / 2));
        double d = Math.Abs(((x5 - x4) ^ 2 + (y5 - y4) ^ 2) ^ (1 / 2));
        double c = Math.Abs(((x1 - x5) ^ 2 + (y1 - y5) ^ 2) ^ (1 / 2));
        double g = Math.Abs(((x1 - x3) ^ 2 + (y1 - y3) ^ 2) ^ (1 / 2));
        double f = Math.Abs(((x5 - x3) ^ 2 + (y5 - y3) ^ 2) ^ (1 / 2));

        double trg (double n, double z, double m) 
        {
            double p = Math.Abs((n + z + m) / 2);
            if (n < p && p > z && p > m)
            {
                double pp = Math.Sqrt(p * (p - n) * (p - z) * (p - m));
                Console.WriteLine($"Площадь треугольник с длинами:{n} , {z} и {m} равна {pp},а полупериметр {p} ");
                return pp;
            }
            else 
            {
                return 0;
                //так не бывает 
            }
        }

        double i1 = trg(b, a, g);
        double i2 = trg(g, f, c);
        double i3 = trg(f, d, e);
        if (0 < i1 && i2 > 0 && i3 > 0)
        {
            double res = i1 + i2 + i3;
            Console.WriteLine($"Площадь пятиугольника равна {res}");
        }
        else
        {
            Console.WriteLine("Такого многоугольника не существует");
        }




    }
}