/* 
    Задать массив из 12 элементов, заполненный случайными числами 
    из промежутка -9 9, и найти сумму отрицательных элементов.
*/ 
Console.Clear();

int[] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1); // тк рандом не берет верхнюю границу
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine(" ]");
    Console.ResetColor();
}

int getSumOfNegative(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        sum = sum + array[i];
    }
    return sum;
}

int getSumOfPositive(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        sum = sum + array[i];
    }
    return sum;
}

int[] Array = generateArray(12, -9, 9);
PrintArray(Array);
Console.WriteLine();
int sumOfNegative = getSumOfNegative(Array);
int sumOfPositive = getSumOfPositive(Array);
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"Сумма отрицательных чисел = {sumOfNegative}");
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {sumOfPositive}");
Console.WriteLine();
Console.ResetColor();