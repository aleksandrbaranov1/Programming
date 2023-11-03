namespace laboratornaya_rabota_4;

class Program
{
    static void Main(string[] args)
    {
        int h, m, s, n, fullTimeInSec, newH, newM, newS;
        bool flg1, flg2, flg3, flg4, error = false;
        string hS, mS, sS;

        Console.Write("Введите часы: ");
        flg1 = int.TryParse(Console.ReadLine(), out h);
        Console.Write("Введите минуты: ");
        flg2 = int.TryParse(Console.ReadLine(), out m);
        Console.Write("Введите секунды: ");
        flg3 = int.TryParse(Console.ReadLine(), out s);
        Console.Write("Введите количество чекунд n: ");
        flg4 = int.TryParse(Console.ReadLine(), out n);

        if (flg1 && flg2 && flg3 && flg4)
        {
            if ((h < 0) || (h > 23))
            {

                error = true;

            }
            if ((m < 0) || (m > 59))
            {

                error = true;
            }
            if ((s < 0) || (s > 59))
            {

                error = true;
            }
            if (n < 0)
            {
                error = true;
            }
            if (!error)
            {
                fullTimeInSec = h * 3600 + m * 60 + s + n;

                newH = fullTimeInSec / 3600;
                newM = (fullTimeInSec - (newH * 3600)) / 60;
                newS = fullTimeInSec - (newH * 3600) - (newM * 60);



                if (Convert.ToString(newH).Length == 1)
                {
                    hS = '0' + (Convert.ToString(newH));
                }
                else
                {
                    hS = Convert.ToString(newH);
                }
                if (Convert.ToString(newM).Length == 1)
                {
                    mS = '0' + (Convert.ToString(newM));
                }
                else
                {
                    mS = Convert.ToString(newM);
                }
                if (Convert.ToString(newS).Length == 1)
                {
                    sS = '0' + (Convert.ToString(newS));
                }
                else
                {
                    sS = Convert.ToString(newS);
                }


                if (fullTimeInSec >= 86400)
                {
                    Console.WriteLine("00:00:00");
                }
                else
                {
                    Console.WriteLine(hS + ":" + mS + ":" + sS);
                }
            }
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }
        }
        else
        {
            Console.WriteLine("Введены некорректные данные");
        }
        Console.ReadKey(true);

    }
}

