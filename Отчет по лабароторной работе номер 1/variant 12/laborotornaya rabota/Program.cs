namespace laborotornaya_rabota;

class Program
{
    static void Main(string[] args)
    {

        int aAbs, aTrigonomtry2, aTrigonomtry3, aMin, aMax, aEquals1, aEquals2, aExp, aLog1, aLog2, aLog10, aPow1, aPow2, aSign, aSqrt, aBigMul1, aBigMul2, aDivRem1, aDivRem2, arg, osnov;
        decimal aCelling, aTruncate, aFloor;
        double aTrigonomtry, aRound, aAtan21, aAtan22, left, right;

        Console.WriteLine("Нажмите на любую кнопку, чтобы начать общую часть работы");
        Console.ReadKey(true);

        Console.WriteLine("Ввод данных для общей части");

        Console.Write("Введите число расчета Abs: ");
        Int32.TryParse(Console.ReadLine(), out aAbs);

        Console.Write("Введите десятичное число с точкой для расчета Celling: ");
        Decimal.TryParse(Console.ReadLine(), out aCelling);

        Console.Write("Введите число от -1 до 1 для расчета Acos, Asin, Atan: ");
        Double.TryParse(Console.ReadLine(), out aTrigonomtry);

        Console.Write("Введите угол, измеряемый в радианах для расчета Sin, Cos, Tan: ");
        Int32.TryParse(Console.ReadLine(), out aTrigonomtry2);

        Console.Write("Введите угол, измеряемый в радианах, для расчета Sinh, Cosh, Tanh");
        Int32.TryParse(Console.ReadLine(), out aTrigonomtry3);


        Console.Write("Введите два числа для расчета Min и Max: ");
        Int32.TryParse(Console.ReadLine(), out aMin);
        Int32.TryParse(Console.ReadLine(), out aMax);

        
        Console.Write("Введите два числа для DivRem: ");
        Int32.TryParse(Console.ReadLine(), out aDivRem1);
        Int32.TryParse(Console.ReadLine(), out aDivRem2);

        Console.Write("Введите два числа для Equals");
        Int32.TryParse(Console.ReadLine(), out aEquals1);
        Int32.TryParse(Console.ReadLine(), out aEquals2);

        Console.Write("Введите число для Exp: ");
        Int32.TryParse(Console.ReadLine(), out aExp);

        Console.Write("Введите аргумент и основание для Log: ");
        Int32.TryParse(Console.ReadLine(), out aLog1);
        Int32.TryParse(Console.ReadLine(), out aLog2);

        Console.Write("Введите аргумент для Log10 ");
        Int32.TryParse(Console.ReadLine(), out aLog10);

        Console.Write("Введите число и степнь для Pow: ");
        Int32.TryParse(Console.ReadLine(), out aPow1);
        Int32.TryParse(Console.ReadLine(), out aPow2);

        Console.Write("Введите число с точкой для Round: ");
        Double.TryParse(Console.ReadLine(), out aRound);

        Console.Write("Введите чсило для Sign: ");
        Int32.TryParse(Console.ReadLine(), out aSign);

        Console.Write("Введите число для Sqrt: ");
        Int32.TryParse(Console.ReadLine(), out aSqrt);

        Console.Write("Введите десятичное число для Truncate: ");
        Decimal.TryParse(Console.ReadLine(), out aTruncate);

        Console.Write("Введите число для Floor: ");
        Decimal.TryParse(Console.ReadLine(), out aFloor);

        Console.Write("Ввдеите 2 числа для Atan2:");
        Double.TryParse(Console.ReadLine(), out aAtan21);
        Double.TryParse(Console.ReadLine(), out aAtan22);

        Console.Write("Введите два целых числа для BigMul: ");
        Int32.TryParse(Console.ReadLine(), out aBigMul1);
        Int32.TryParse(Console.ReadLine(), out aBigMul2);

        Console.WriteLine("Ввод данных для индивидуальной части");

        Console.Write("Введите значение для аргумента логарифма: ");
        Int32.TryParse(Console.ReadLine(), out arg);
        Console.Write("Введите значение для основания логарифма: ");
        Int32.TryParse(Console.ReadLine(), out osnov);


        Console.Write("Нажмите любую кнопку для расчета общей части");
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
        Console.WriteLine("Экспонента:" + " " + Math.E);
        Console.WriteLine("Число ПИ:" + " " + Math.PI);
        Console.WriteLine("Остаток от частного двух чисел:" + " " + Math.DivRem(aDivRem1, aDivRem2));
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

        Console.WriteLine("Нажмите любую кнопку для расчета индивидуальной части");
        Console.ReadKey(true);
        left = Math.Log(arg, osnov);
        right = Math.Log(arg, Math.E) / Math.Log(osnov, Math.E);
        Console.WriteLine("Значение левой части:" + " " + left);
        Console.WriteLine("Значение правой части:" + " " + right);
        Console.WriteLine(left.Equals(right));
        Console.ReadKey(true);
    }
}
