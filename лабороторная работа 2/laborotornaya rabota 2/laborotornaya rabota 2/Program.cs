namespace laborotornaya_rabota_2;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c, a1, a2, a3, a4, b1, b2, c1, c2, result1, a5, a6, result2;
        #region razbivka;


        a1 = (6.84 / (Math.Pow((28.57 - 25.15), (1f / 5f))));
        a2 = ((1 / 0.3) - 2.7) / 4.12;
        a3 = (34.06 - 33.81) * 4;
        a4 = 3 + (4.2 / 0.1);
        b1 = 2f / 3f;
        b2 = 4f / 21f;
        b = b1 / b2;
        c1 = 1 + Math.Pow(5, 1f / 3f);
        c2 = c1 / 3.5;
        c = Math.Pow(c2, 0.25); 
        a5 = a3 / a1;
        a6 = Math.Sqrt(a4 / a2);
        a = 26 / (a5 - a6);

        #endregion;
        result1 = a + b + c;
        result2 = (26 / ((((34.06 - 33.81) * 4) / (6.84 / Math.Pow((28.57 - 25.15), 0.2))) - Math.Sqrt((3 + (4.2 / 0.1)) / (((1f / 0.3) - 2.7) / 4.12)))) + ((2f / 3f) / (4f / 21f)) + Math.Pow(((1 + Math.Pow(5, 1f / 3f)) / 3.5), 0.25);
        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.ReadKey(true);
    }
}

