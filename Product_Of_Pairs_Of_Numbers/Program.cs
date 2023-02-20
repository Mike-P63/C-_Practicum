/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний 
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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
int GetUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return userData;
}
int[] newArray(int[] array)
{
    int newlength = (int)Math.Ceiling(array.Length / 2.0);
    int[] arr = new int[newlength];
    for (int i = 0; i < newlength; i++)
    {
        if (i < newlength - 1 || array.Length % 2 == 0)
        {
            arr[i] = array[i] * array[array.Length - i - 1];
        }
        else
        {
            arr[i] = array[i];
        }
    }
    return arr;
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

int number = GetUserData("Введите количество элементов массива");
int[] array = FillArray(number, 1, 10);
PrintArray(array);
int[] array2 = newArray(array);
PrintArray(array2);