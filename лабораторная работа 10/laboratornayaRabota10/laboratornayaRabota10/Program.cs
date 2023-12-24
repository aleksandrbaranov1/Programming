namespace laboratornayaRabota10;

class Program
{
    static string _lSplit(string inputString, char delimiter)
    {
        int substrCount = 1, start = 0, index = 0;
        string result;
        for (int i = 0; i < inputString.Length; i++)
        {
            if (inputString[i] == delimiter)
                substrCount++;
        }
        string[] substrings = new string[substrCount]; 
        for (int i = 0; i < inputString.Length; i++)
        {
            if (inputString[i] == delimiter)
            {
                substrings[index++] = inputString.Substring(start, i - start);
                start = i + 1; 
            }
        }
        substrings[index] = inputString.Substring(start);
        result = string.Join(" ", substrings);
        return result; 
    }
    static void Main()
    {
        string input, result;
        char delimiter;
        bool flg;
        Console.Write("Введите строку: ");
        input = Console.ReadLine();
        Console.Write("Введите символ для разделения: ");
        flg = char.TryParse(Console.ReadLine(), out delimiter);
        if (flg)
        {
        result = _lSplit(input, delimiter);
        Console.Write("Результат разделения: ");
        Console.Write(result);
        }
        else
        {
            Console.WriteLine("Введены неверные данные");
        }
        Console.ReadKey(true);
    }
}

