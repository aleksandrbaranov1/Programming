﻿using System;
namespace laboratornayaRabota6;

class Program
{
    static void Main(string[] args)
    {
        double b0, bx, db, a, eps = 0.001, b, l;
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
            while (b0 < bx)
            {
                count += 1;
                flg1 = Math.Abs(Math.Cos(b0)) >= eps;
                flg2 = Math.Abs(Math.Pow((Math.Pow(Math.E, a) - (b0 * b0 * b0) + Math.Tan(b0)), 1f / 3f)) >= eps;
                if (flg1 && flg2)
                {
                    l = (24.2 * Math.Cos(a * a) + Math.Sin(a + b0)) / (Math.Pow((Math.Pow(Math.E, a) - (b0 * b0 * b0) + Math.Tan(b0)), 1f / 3f));
                    Console.WriteLine($"{count})При B = {b0} L(B) = {l}");
                }
                else
                {
                    Console.WriteLine($"{count})При B = {b0}, L(B) не сущетвует");
                }

                b0 += db;
                if (count % 20 == 0)
                {
                    Console.ReadKey(true);
                }
            }
        }
        else
        {
            Console.WriteLine("Введены неверные данные");
        }

        Console.ReadKey(true);

    }
}

