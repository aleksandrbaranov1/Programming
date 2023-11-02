namespace laborotornaya_rabota_3;

class Program
{
    static void Main(string[] args)
    {
        double a, b, m, n, z, eps = 0.001;
        bool flg1, flg2, flg3, error = false;
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
                if (b >= 0)
                {
                    a = Math.Pow(b, 2) - (b * Math.Sqrt(b));
                }
                else
                {
                    a = default;
                    error = true;
                }
            }

            if (!error)
            {
                flg1 = (a * a + b) >= 0;
                if (flg1)
                {
                    flg2 = Math.Abs(Math.Cos(((Math.Sqrt(Math.Pow(a, 2) + b))))) >= eps;
                    if (flg2)
                    {
                        flg3 = Math.Abs(a - Math.Tan(Math.Sqrt(Math.Pow(a, 2) + b))) >= eps;
                        if (flg3)
                        {
                            z = (a * a + Math.Cos(a)) / (a - Math.Tan(Math.Sqrt(a * a + b)));
                            Console.WriteLine("Z = " + z);
                        }
                        else
                        {
                            error = true;
                        }
                    }
                    else
                        error = true;
                }
                else
                    error = true;
            }
            else
                Console.WriteLine("a не существует, Z - тем более");
            if (error == true)
            {
                Console.WriteLine("Ошибка");
            }
        }
        else
            Console.WriteLine("Введены некорректные данные");

        Console.ReadKey(true);


    }
}


