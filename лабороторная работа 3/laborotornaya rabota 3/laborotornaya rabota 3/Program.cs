namespace laborotornaya_rabota_3;

class Program
{
    static void Main(string[] args)
    {
        double a, b, m, n, z, eps = 0.001;
        bool flg1, flg2;
        Console.Write("Введите значение для переменной m: ");
        flg1 = Double.TryParse(Console.ReadLine(), out m);
        Console.Write("Введите значение для переменной n: ");
        flg2 = Double.TryParse(Console.ReadLine(), out n);

        if (flg1 && flg2)
        {

            if (m > n)
            {
                b = m;
            }
            else
            {
                b = Math.Pow(m, 2) * n;
            }

            if (b > 5)
            {
                a = Math.Cos(b);
            }
            else
            {
                a = Math.Pow(b, 2) - (b * Math.Sqrt(b));
            }
            flg1 = Math.Abs(a - Math.Tan(Math.Sqrt(Math.Pow(a, 2) + b))) >= eps;
            flg2 = ((Math.Sqrt(Math.Pow(a, 2) + b) != 270) && ((Math.Sqrt(Math.Pow(a, 2) + b) != 90)));

            z = (Math.Pow(a, 2) + Math.Cos(a)) / (a - Math.Tan(Math.Sqrt(Math.Pow(a, 2) + b)));

            if(flg1 && flg2)
            {
                Console.WriteLine("Значение арифметического выражение: " + z);
            }
            else
            {
                Console.WriteLine("Невозможно решить");
            }
        }
        else
        {
            Console.WriteLine("Введены некорректные данные");
        }
        Console.ReadKey(true);

    }
}

