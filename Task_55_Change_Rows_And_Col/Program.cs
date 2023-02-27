/*
Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести 
сообщение для пользователя.
*/ 
Console.Clear();

int[,] generateArray(int collength, int rowlength, int start, int end)
{
    int[,] array = new int[collength, rowlength];
    for (int i = 0; i < collength; i++)
    {
        for (int j = 0; j < rowlength; j++)
        {
            array[i,j]= new Random().Next(start, end+1);
        }
    }
    return array;
}

void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}

void printHeadOfArray(int length)
{
    Console.Write("\t");
    for (int i = 0; i < length; i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}

void printArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i +"\t",ConsoleColor.DarkBlue);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("------------------------------------------------------");
}
int GetDataFromUser(string message)
{
    printInColor(message + "\n", ConsoleColor.DarkBlue);
    int data = int.Parse(Console.ReadLine()!);
    return data;
}
bool CheckCanRotate(int rows, int col)
{
    return rows == col;
}
int[,] rotateMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int tmp = array[i,j]; 
            array[i,j] = array[j, i]; 
            array[j,i] = tmp;
        } 
    }
    return array;
}
int rows = GetDataFromUser("Введите количество строк");
int col = GetDataFromUser("Введите количество колонок");
bool canContinue= CheckCanRotate(rows, col);
if (canContinue)
{
    int[,] array = generateArray(rows,col,1,10);
    printArray(array);
    int[,] rotatedArray = rotateMatrix(array);
    printArray(rotatedArray);
}
else
{
    printInColor($"Для переворота нужна квадратная матрица а вы ввели [{rows}:{col}]" , ConsoleColor.Red);
}
