/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int ArrayLen = getUserData("Введите количество чисел массива");

int[] FillArray(int ArrayLen)
{
    int[] array = new int[ArrayLen];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число под номером {i + 1}:\t");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine(" ]");
}

int BiggerThenZerro(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }        
    }
    return count;
}

int[] array = FillArray(ArrayLen);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkBlue;
PrintArray(array);
Console.ResetColor();
int result = BiggerThenZerro(array);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Количество чисел больше чем 0 = {result}");
Console.ResetColor();
Console.WriteLine();
