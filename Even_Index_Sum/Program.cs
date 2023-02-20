/*
Задать одномерный массив, заполненный случайными числами.
Найти сумму элементов на четных позициях.
*/
Console.Clear();

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
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
int evenIndexSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum = sum + array[i];

    }
    return sum;
}
int number = getUserData("Введите количество элементов массива");
int[] array = FillArray(number);
PrintArray(array);
Console.WriteLine();
int result = evenIndexSum(array);
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"Сумма элементов на четных позициях = {result}");
Console.ResetColor();
Console.WriteLine();