/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
Console.Clear();

int[] FillArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
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
int Find(int[] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array[i] <= end)
        {count +=1;
        }
    }
    return count;
}
void printArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(" ,");
        }
    }
    Console.WriteLine(" ]");
}

int number = getUserData("Введите количество элементов массива");
int[] array = FillArray(number, 1, 150);
printArray(array);
int start = getUserData("Введите начальное число диапазона");
int end = getUserData("Введите конечное число диапазона");
int count = Find(array, start, end);
Console.WriteLine($"Количество элементов диапазоне [{start},{end}] = {count};");
