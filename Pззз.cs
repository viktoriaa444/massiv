using System;
using System.Drawing;
using System.Reflection;

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
        


        double trg(int X1, int Y1, int X2, int Y2, int X3, int Y3)
        {
            double n = Math.Abs(((X2 - X1) ^ 2 + (Y2 - Y1) ^ 2) ^ (1 / 2));  //длина отрезков
            double z = Math.Abs(((X3 - X2) ^ 2 + (Y3 - Y2) ^ 2) ^ (1 / 2));
            double m = Math.Abs(((X1 - x3) ^ 2 + (Y1 - Y3) ^ 2) ^ (1 / 2));

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
        double i1 = trg(x1, y1,x2, y2, x3, y3);  //значение площади треугольника
        double i2 = trg(x3, y3, x5, y5, x1, y1);
        double i3 = trg(x3, y3, x5, y5, x4, y4);
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