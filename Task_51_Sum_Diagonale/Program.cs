/*
Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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
void PrintInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(data);
    Console.ResetColor();
}

int[,] DoubleArray(int collength, int rowlength, int start, int finish)
{
    int[,] array = new int[collength, rowlength];
    for (int i = 0; i < collength; i++)
    {
        for (int j = 0; j < rowlength; j++)
        {
            array[i,j] = new Random().Next(start,finish+1 );
        }
    }
    return array;
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
int FindSum(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==j)
            {
                result = result + array[i,j];
            }
        }
    }
    return result;
}
int m = GetDataFromUser("Введите количество столбцов");
int n = GetDataFromUser("Введите количество строк");
int[,] array = DoubleArray(m, n, 0, 10);
Print2DArray(array);
Console.WriteLine();
int sum = FindSum(array);
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");