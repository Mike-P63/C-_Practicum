/*Заполнить массив случайными положительными трехзначными числами
Написать программу, которая покажет количество четных чисел в массиве.
[345, 897, 568, 234] - 2;
*/

Console.Clear();

int[] FillArray (int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 250);
    }
    return array;
}
int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return userData;
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
int evenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {count+=1;
        }
    }
    return count;
}
int number = getUserData("Введите количество элементов массива");
int[] array = FillArray(number);
PrintArray(array);
Console.WriteLine();
int result = evenNumbers(array);
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"Количество четных чисел в массиве = {result}");
Console.ResetColor();
Console.WriteLine();