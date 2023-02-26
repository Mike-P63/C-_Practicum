/*
Задача 49: Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
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
int[,] ChangeIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i%2 == 0 && j%2 == 0)
            {
                array[i,j] = (int) Math.Pow(array[i,j],2);
            }
        }
    }
    return array;
}
int m = GetDataFromUser("Введите количество столбцов");
int n = GetDataFromUser("Введите количество строк");
int[,] array = DoubleArray(m, n, 0, 100);
Print2DArray(array);
Console.WriteLine();
int[,] result = ChangeIndex(array);
Print2DArray(array);
Console.WriteLine();