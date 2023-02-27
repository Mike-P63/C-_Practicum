/*
Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет местами 
первую и последнюю строку массива.
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

int[,] swapRows(int[,] array, int row1, int row2)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tmp = array[row1, i]; //[i, row1]; меняем столбцы...
        array[row1, i] = array[row2, i]; //[i, row2]...
        array[row2, i] = tmp;
    }  
    return array; 
}

int[,] array = generateArray(5,5,1,10);
printArray(array);
Console.WriteLine();
int[,] swaped = swapRows(array,0,array.GetLength(0)-1);
printArray(swaped);