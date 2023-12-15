using System;
namespace laboratornayaRabota8;

class Program
{
    static void Main(string[] args)
    {
        int n, count = 0;
        bool flg1 = true, flg2 = true, flg3 = true;
        double eps = 0.001, func;
        Console.Write("Введите длину одномерного массива: ");
        flg1 = Int32.TryParse(Console.ReadLine(), out n);
        if (flg1)
        {
            double[] x = new double[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива: ");
                flg2 = Double.TryParse(Console.ReadLine(), out x[i]);
                if (flg2 == false)
                    break;
            }
            if (flg2)
            {
                for(int i = 0; i < n; i++)
                {
                    func = x[i] / x[(n - 1) - i];
                    if (Math.Abs(x[i]) <= eps)
                    {
                        func = 0;
                    }
                    if (Math.Abs(x[(n - 1) - i]) < eps)
                    {
                        Console.WriteLine("Невозможно решить задачу");
                        flg3 = false;
                    }
                    if (func > 1)
                        count ++;
                }
                if (flg3)
                    Console.WriteLine($"Количество элементов, удовлетворяющих условию: {count}");
            }
            else
            {
                Console.WriteLine("Введены неверные данные");
            }
        }
        else
        {
            Console.WriteLine("Введены неверные данные");
        }
        Console.ReadKey(true);
    }
}

