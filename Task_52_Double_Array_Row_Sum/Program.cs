/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/ 
Console.Clear();

int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int[,] generateArray(int collength, int rowlength, int start, int end)
{
    int[,] array = new int[collength, rowlength];
    for (int i = 0; i < collength; i++)
    {
        for (int j = 0; j < rowlength; j++)
        {
            array[i,j] = new Random().Next(start, end+1);
        }

    }
    return array;
}
void PrintInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(data);
    Console.ResetColor();
}
void Print2DArray(int[,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        PrintInColor(i + "\t");
    }
    Console.WriteLine("\t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        PrintInColor(j + "\t");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();    
    }
}
void AveregeInRow(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double result = 0.0;
        for (int j = 0; j < array.GetLength(1);j++)
        {
            result += array[i,j];
        }
        average[i] = result/array.GetLength(1);
    }
    Console.WriteLine($"Сренее арифметическое каждого столбца -> ");
    PrintArray(average);
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.Write(" ]");
}

int collength = GetDataFromUser("Введите количество столбцов");
int rowlength = GetDataFromUser("Введите количество строк");
int[,] array = generateArray(collength, rowlength, 1, 20);
Print2DArray(array);
Console.WriteLine();
AveregeInRow(array);
Console.WriteLine();

