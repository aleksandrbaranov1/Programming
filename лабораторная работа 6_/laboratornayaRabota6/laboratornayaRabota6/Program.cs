using System;
namespace laboratornayaRabota6;

class Program
{
    static void Main(string[] args)
    {
        double b0, bx, db, a, eps = 0.001, b, l, tmpb0;
        bool flg1 = false, flg2 = false, flg3 = false, flg4 = false;
        int count;
        Console.Write("Введите начальный диапазон B: ");
        flg1 = double.TryParse(Console.ReadLine().Replace(',', '.'), out b0);
        Console.Write("Введите конечный диапазон B: ");
        flg2 = double.TryParse(Console.ReadLine().Replace(',', '.'), out bx);
        Console.Write("Введите шаг для диапазона от B0 до до BX: ");
        flg3 = double.TryParse(Console.ReadLine().Replace(',', '.'), out db);
        Console.Write("Введите значения для переменной a: ");
        flg4 = double.TryParse(Console.ReadLine().Replace(',', '.'), out a);
        if (flg1 && flg2 && flg3 && flg4)
        {
            count = 0;
            b = b0;
            while (b < bx)
            {
                count += 1;
                flg1 = Math.Abs(Math.Cos(b)) >= eps;
                if (flg1)
                {
                    flg2 = Math.Abs(Math.Pow((Math.Pow(Math.E, a) - (b * b * b) + Math.Tan(b)), 1f / 3f)) >= eps;
                    if (flg2)
                    {
                        l = (24.2 * Math.Cos(a * a) + Math.Sin(a + b)) / (Math.Pow((Math.Pow(Math.E, a) - (b * b * b) + Math.Tan(b0)), 1f / 3f));
                        Console.WriteLine($"{count})При B = {b} L(B) = {l}");
                    }
                    else
                    {
                        Console.WriteLine($"{count})При B = {b}, L(B) не сущетвует");
                    }
                }
                else
                {
                    Console.WriteLine($"{count})При B = {b}, L(B) не сущетвует");
                }
                b += db;
                if (count % 20 == 0)
                {
                    Console.ReadKey(true);
                }
            }
            Console.WriteLine($"График функции L(b) успешно построен в диапазоне от b0 = {b0} до bx = {bx} с шагом db = {db}");
        }
        else
        {
            Console.WriteLine("Введены неверные данные");
        }

        Console.ReadKey(true);

    }
}

