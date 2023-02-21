/* Задача 45: Напишите программу, которая будет создавать 
копию заданного массива с помощью поэлементного копирования.
*/ 
Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int[] FillArray(int length, int start, int end)
{
    int[] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end+1);
    }
    return array;
}
int[] CopyArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
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
int number = getUserData("Введите количество элементов массива");
int[] array = FillArray(number, 10,50);
PrintArray(array);
int[] result = CopyArray(array);
PrintArray(result);


