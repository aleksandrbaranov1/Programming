using System;
namespace laboratornayaRabota7;
class Program
{
    static void Main(string[] args)
    {
        double x, a, l = 0, eps = 0.001, term;
        bool flg1, flg2, flg3, error = false;
        int n, k1 = 0, m = 0, s = 1, a1 = 0, sign = 1;
        Console.Write("Введите значение для перменной x: ");
        flg1 = Double.TryParse(Console.ReadLine(), out x);
        Console.Write("Введите значение для перменной a: ");
        flg2 = Double.TryParse(Console.ReadLine(), out a);
        Console.Write("Введите количество элементов n: ");
        flg3 = Int32.TryParse(Console.ReadLine(), out n);
        if (flg1 && flg2 && flg3)
        {
            for(int i = 0; i < n; i++)
            {
                k1 += 2;
                m += 5;
                s += 1;
                a1 += 2;
                flg1 = (Math.Pow(Math.Sin(x), k1) + Math.Pow(a, a1)) >= 0;
                flg2 = Math.Abs(Math.Sqrt((Math.Pow(Math.Sin(x), s) + Math.Pow(a, a1)))) >= eps;
                if (flg1 && flg2)
                {
                    term = (Math.Pow(x, k1) + m) / (Math.Sqrt((Math.Pow(Math.Sin(x), s) + Math.Pow(a, a1))));
                    l += term * sign;
                    sign *= -1;
                }
                else
                {
                    error = true;
                    Console.WriteLine("Невозможно решить ряд L");
                    break;
                }
            }
            if(error == false)
                Console.WriteLine($"Результат расчета ряда L = {l}");
        }
        else
        {
            Console.WriteLine("Введены неверные данные");
        }
        Console.ReadKey(true);
    }
}