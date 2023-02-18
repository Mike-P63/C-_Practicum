/* Введите два числа и возведите первое в натуральную степень второго*/

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int DigitSum(int numberA, int numberB)
{
    int result = 1;
    for(int i = 1; i <= numberB; i++)
    {
        result = result * numberA;        
    }
    return result;
}

int numberA = getUserData($"Введите число А ");
int numberB = getUserData($"Введите число B ");
int Result = DigitSum(numberA, numberB);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write($"Результат возведения в степень = {Result}");
Console.ResetColor();
Console.WriteLine();