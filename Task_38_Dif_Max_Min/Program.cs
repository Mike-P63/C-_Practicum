/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();

int size = 8;
int[] numbers = new int[size];

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 300);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ]");
}

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int max = numbers[0];
int min = numbers[0];
int dif = 0;
void Difference(int max, int min, int dif)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
        max = numbers[i];
        }
        else if (numbers[i] < min)
        {
        min = numbers[i];
        }
        dif = max - min;
    }
Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {dif}");
}
Difference(max,min,dif);

