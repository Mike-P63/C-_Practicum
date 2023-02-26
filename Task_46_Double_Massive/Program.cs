/*
Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
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

double[,] get2DoubleArray(int collength, int rowlength, int start, int finish)
{
    double[,] array = new double[collength,rowlength];
    const int divider = 100;
    for (int i = 0; i < collength; i++)
    {
        
        for (int j = 0; j < rowlength; j++)
        {
            array[i,j] = new Random().Next(start*divider,finish+1 * divider) / (divider + 0.0);

        }
    }
    return array;
}
void Print2DArray(double[,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        PrintInColor(i + "\t");
    }
    Console.WriteLine();
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
int m = GetDataFromUser("Введите количество столбцов");
int n = GetDataFromUser("Введите количество строк");
double[,] array = get2DoubleArray(m, n, 0, 1000);
Print2DArray(array);
Console.WriteLine();
