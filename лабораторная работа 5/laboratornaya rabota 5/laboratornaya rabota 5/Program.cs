namespace laboratornaya_rabota_5;

class Program
{
    static void Main(string[] args)
    {
        double inputMass, weigth;
        bool flg1;
        int number;

        Console.Write("Введите число с одним знаком после запятой: ");
        flg1 = Double.TryParse(Console.ReadLine(), out inputMass);

        if (flg1)
        {
            number = Convert.ToInt32(Math.Truncate(inputMass));
            weigth = Convert.ToInt32((inputMass - number) * 10);

            switch (number)
            {
                case 1:
                    Console.WriteLine("Вес в килограммах: " + weigth);
                    break;
                case 2:
                    Console.WriteLine("Вес в килограммах: " + weigth / 1_000_000);
                    break;
                case 3:
                    Console.WriteLine("Вес в килограммах: " + weigth / 1_000);
                    break;
                case 4:
                    Console.WriteLine("Вес в килограммах: " + weigth * 1_000);
                    break;
                case 5:
                    Console.WriteLine("Вес в килограммах: " + weigth * 100);
                    break;
                default:
                    Console.WriteLine("Неизвестная величина");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Введены некорректные данные");
        }
        Console.ReadKey(true);
    }
}

