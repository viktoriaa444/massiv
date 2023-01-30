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
        switch(q)
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
                float res1 = a1*b1/c1;
                Console.WriteLine($"Ответ:{res1}");
                break;
            case "в":
                Console.WriteLine("Введите а");
                int a2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите b");
                int b2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите c");
                int c2 = Convert.ToInt32(Console.ReadLine());
                float res2 = a2/b2*c2;
                Console.WriteLine($"Ответ:{res2}");
                break;
                
        }

    }
}