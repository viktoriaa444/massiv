using System;
using System.Data;
using System.IO.IsolatedStorage;

class Program
{
    static void Main(string[] args)
    {
        //Перевести из линейной записи в обычную следующие выражения
        Console.WriteLine("Введите букву выражения, которого хотите проверить");
        string q = Console.ReadLine();
        switch (q)
        {
            case "а":
                Console.WriteLine("Введите а");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите с");
                int c = Convert.ToInt32(Console.ReadLine());
                float res = a / b / c;
                Console.WriteLine($"Ответ:{res}");
                break;
            case "б":
                Console.WriteLine("Введите а");
                int a1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите c");
                int c1 = Convert.ToInt32(Console.ReadLine());
                float res1 = a1 * b1 / c1;
                Console.WriteLine($"Ответ:{res1}");
                break;
            case "в":
                Console.WriteLine("Введите а");
                int a2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите c");
                int c2 = Convert.ToInt32(Console.ReadLine());
                float res2 = a2 / b2 * c2;
                Console.WriteLine($"Ответ:{res2}");
                break;
            case "г":
                Console.WriteLine("Введите а");
                int a3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите c");
                int c3 = Convert.ToInt32(Console.ReadLine());
                float res3 = a3 + b3 / c3;
                Console.WriteLine($"Ответ:{res3}");
                break;
            case "д":
                Console.WriteLine("Введите а");
                int a4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите c");
                int c4 = Convert.ToInt32(Console.ReadLine());
                float res4 = (a4 + b4) / c4;
                Console.WriteLine($"Ответ:{res4}");
                break;
            case "е":
                Console.WriteLine("Введите а");
                int a5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите c");
                int c5 = Convert.ToInt32(Console.ReadLine());
                float res5 = a5 + b5 / b5 + c5;
                Console.WriteLine($"Ответ:{res5}");
                break;
            case "ж":
                Console.WriteLine("Введите а");
                int a6 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b6 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите c");
                int c6 = Convert.ToInt32(Console.ReadLine());
                float res6 = (a6 + b6) / (b6 + c6);
                Console.WriteLine($"Ответ:{res6}");
                break;
            case "з":
                Console.WriteLine("Введите а");
                int a7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b7 = Convert.ToInt32(Console.ReadLine());
                double p = Math.Sin(b7);
                int p1 = Convert.ToInt32(p);
                int res7 = a7 / p1;
                Console.WriteLine($"Ответ:{res7}");
                break;
            case "и":
                Console.WriteLine("Введите а");
                int a8 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b8 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите х");
                int x = Convert.ToInt32(Console.ReadLine());
                double p2 = Math.Sin(x);
                int p11 = Convert.ToInt32(p2);
                int res8 = (1/2)*a8*b8*p11;
                Console.WriteLine($"Ответ:{res8}");
                break;
            case "к":
                Console.WriteLine("Введите а");
                int a9 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b9 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите c");
                int c9 = Convert.ToInt32(Console.ReadLine());
                
                double p3 = Math.Cos(a9/2);
                int p111 = Convert.ToInt32(p3);
                int res9 = (2*b9*c9*p111) / (b9+c9);
                Console.WriteLine($"Ответ:{res9}");
                break;
            case "л":
                Console.WriteLine("Введите а");
                int a10 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b10 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите c");
                int c10 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите R");
                int r = Convert.ToInt32(Console.ReadLine());

                double p4 = Math.Sin(a10 / 2);
                int p1111 = Convert.ToInt32(p4);
                double p44 = Math.Sin(b10 / 2);
                int p14 = Convert.ToInt32(p4);
                double p5 = Math.Sin(c10 / 2);
                int p15 = Convert.ToInt32(p4);
                int res10 = 4*r*p1111*p14*p15;
                Console.WriteLine($"Ответ:{res10}");
                break;
            case "м":
                Console.WriteLine("Введите а");
                int a11 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b11 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите c");
                int c11 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите х");
                int x2 = Convert.ToInt32(Console.ReadLine());
                int res11 = (a11*x2+b11)/(c11*x2+b11);
                Console.WriteLine($"Ответ:{res11}");
                break;
            case "н":
                Console.WriteLine("Введите а");
                int a12 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b12 = Convert.ToInt32(Console.ReadLine());
                
                double p12 = Math.Sin((a12+b12) / 2);
                int p112 = Convert.ToInt32(p12);
                double p13 = Math.Cos((a12-b12) / 2);
                int p113 = Convert.ToInt32(p13);
                
                int res12 = 2*p112*p113;
                Console.WriteLine($"Ответ:{res12}");
                break;
            case "о":
                Console.WriteLine("Введите x");
                int w = Convert.ToInt32(Console.ReadLine());

                int i = Math.Abs(w/2);
                double p16 = Math.Sin(-3*i);
                int p116 = Convert.ToInt32(p16);
                int i1 = Math.Abs(2*p116);
                Console.WriteLine($"Ответ:{i1}");
                break;
            default:
                Console.WriteLine("не то((");
                break;
        }

    }
}
