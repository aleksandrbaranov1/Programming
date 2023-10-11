using System;

namespace laborotornaya_rabota_1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int aAbs, aTrigonomtry2, aTrigonomtry3, aMin, aMax, aEquals1, aEquals2, aExp, aLog1, aLog2, aLog10, aPow1, aPow2, aSign, aSqrt, aBigMul1, aBigMul2;
            decimal aCelling, aTruncate, aFloor;
            double aTrigonomtry, aRound, aAtan21, aAtan22;

            Console.WriteLine("Нажмите на любую кнопку, чтобы начать общую часть работы");
            Console.ReadKey(true);

            Console.WriteLine("Введите число расчета Abs:");
            Int32.TryParse(Console.ReadLine(), out aAbs);

            Console.WriteLine("Введите десятичное число с точкой, чтобы получить наименьшее целое число, которое больше или равно указанному числу");
            Decimal.TryParse(Console.ReadLine(), out aCelling);

            Console.WriteLine("Введите число от -1 до 1, изучения тригонометрических функций");
            Double.TryParse(Console.ReadLine(), out aTrigonomtry);

            Console.WriteLine("Введите угол, измеряемый в радианах, для получение его косинуса, синуса и тангенса");
            Int32.TryParse(Console.ReadLine(), out aTrigonomtry2);

            Console.WriteLine("Введите угол, измеряемый в радианах, для получения гиперболического косинуса, синуса и тангенса");
            Int32.TryParse(Console.ReadLine(), out aTrigonomtry3);


            Console.WriteLine("Введите два числа, чтобы получить максимальное и минимальное из них");
            Int32.TryParse(Console.ReadLine(), out aMin);
            Int32.TryParse(Console.ReadLine(), out aMax);

            Console.WriteLine("Нажмите любую клавишу, для получения математических констант");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Экспонента:" + " " + Math.E);
            Console.WriteLine("Число ПИ:" + " " + Math.PI);

            Console.WriteLine("Введите два числа, чтобы узнать частное и остаток от их частного");
            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Остаток от частного двух чисел:" + " " + Math.DivRem(a, b));

            Console.WriteLine("Введите два числа, чтобы проверить их равность");
            Int32.TryParse(Console.ReadLine(), out aEquals1);
            Int32.TryParse(Console.ReadLine(), out aEquals2);

            Console.WriteLine("Введите число, для возведения числа 'e' в эту степень");
            Int32.TryParse(Console.ReadLine(), out aExp);

            Console.WriteLine("Введите аргумент и основание для логарифма");
            Int32.TryParse(Console.ReadLine(), out aLog1);
            Int32.TryParse(Console.ReadLine(), out aLog2);

            Console.WriteLine("Введите аргумент, для десятичного логарифма");
            Int32.TryParse(Console.ReadLine(), out aLog10);

            Console.WriteLine("Введите число и степнь, в которую его нужно возвести");
            Int32.TryParse(Console.ReadLine(), out aPow1);
            Int32.TryParse(Console.ReadLine(), out aPow2);

            Console.WriteLine("Введите число с точкой, для его округления");
            Double.TryParse(Console.ReadLine(), out aRound);

            Console.WriteLine("Введите чсило. Если оно отрицательное, то программа вернет '-1', если положительное, то '1', если число равно 0, '0'");
            Int32.TryParse(Console.ReadLine(), out aSign);

            Console.WriteLine("Введите число, чтобы узнать его корень");
            Int32.TryParse(Console.ReadLine(), out aSqrt);

            Console.WriteLine("Введите десятичное число, чтобы получить его целую часть");
            Decimal.TryParse(Console.ReadLine(), out aTruncate);

            Console.WriteLine("Введите число, чтобы получить наибольшее целое число, которое меньше или равно указанному числу");
            Decimal.TryParse(Console.ReadLine(), out aFloor);

            Console.WriteLine("Ввдеите занчение x и y:");
            Double.TryParse(Console.ReadLine(), out aAtan21);
            Double.TryParse(Console.ReadLine(), out aAtan22);

            Console.WriteLine("Введите два целых числа для их произведения:");
            Int32.TryParse(Console.ReadLine(), out aBigMul1);
            Int32.TryParse(Console.ReadLine(), out aBigMul2);

            Console.WriteLine("Нажмите любую кнопку для расчета общей части");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Модуль данного числа равен" + " " + Math.Abs(aAbs));
            Console.WriteLine("Наименьшее число, которое больше или равно указанному числу: " + Math.Ceiling(aCelling));
            Console.WriteLine("Угол, косинус которого равен указанному числу равен" + " " + Math.Acos(aTrigonomtry));
            Console.WriteLine("Угол, синус которого равен указанному числу равен" + " " + Math.Asin(aTrigonomtry));
            Console.WriteLine("Угол, тангенс которого равен указанному числу равен " + " " + Math.Atan(aTrigonomtry));
            Console.WriteLine("косинус:" + " " + Math.Cos((aTrigonomtry * Math.PI) / 180));
            Console.WriteLine("синус:" + " " + Math.Sin((aTrigonomtry * Math.PI) / 180));
            Console.WriteLine("тангенс" + " " + Math.Tan((aTrigonomtry * Math.PI) / 180));
            Console.WriteLine("гиперболический косинус:" + " " + Math.Cosh((aTrigonomtry3 * Math.PI) / 180));
            Console.WriteLine("гиперболический синус:" + " " + Math.Sinh((aTrigonomtry3 * Math.PI) / 180));
            Console.WriteLine("гиперболический тангенс:" + " " + Math.Tanh((aTrigonomtry3 * Math.PI) / 180));
            Console.WriteLine("максимальное число:" + " " + Math.Max(aMin, aMax));
            Console.WriteLine("минимальное число:" + " " + Math.Min(aMin, aMax));
            Console.WriteLine("равность двух чисел: " + Math.Equals(aEquals1, aEquals2));
            Console.WriteLine("Результат возведения числа 'e' в эту степень:" + " " + Math.Exp(aExp));
            Console.WriteLine("Ответ на логарифм:" + " " + Math.Log(aLog1, aLog2));
            Console.WriteLine("Ответ на логарифм:" + " " + Math.Log10(aLog10));
            Console.WriteLine("Число в степени:" + " " + Math.Pow(aPow1, aPow2));
            Console.WriteLine("Округленное число:" + " " + Math.Round(aRound));
            Console.WriteLine("результат: " + Math.Sign(aSign));
            Console.WriteLine("Корень этого числа:" + " " + Math.Sqrt(aSqrt));
            Console.WriteLine("Целая часть этого числа:" + " " + Math.Truncate(aTruncate));
            Console.WriteLine("Наибольшее целое число, которое меньше или равно указанному числу:" + " " + Math.Floor(aFloor));
            Console.WriteLine("Угол, тангенс которого равен отношению двух указанных чисел:" + " " + Math.Atan2(aAtan21, aAtan22));
            Console.WriteLine("Произведение данных чисел равно" + " " + Math.BigMul(aBigMul1, aBigMul2));

            Console.WriteLine("Нажмите любую кнопку, чтобы начать вторую часть работы");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Вариант 12");

            double left;
            double right;
            int arg;
            int osnov;
            Console.WriteLine("Введите значение для аргумента логарифма");
            Int32.TryParse(Console.ReadLine(), out arg);
            Console.WriteLine("Введите значение для основания логарифма");
            Int32.TryParse(Console.ReadLine(), out osnov);
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            left = Math.Log(arg, osnov);
            right = Math.Log(arg, Math.E) / Math.Log(osnov, Math.E);
            Console.WriteLine("Значение левой части:" + " " + left);
            Console.WriteLine("Значение правой части:" + " " + right);
            Console.WriteLine(left.Equals(right));

        }
    }
}
