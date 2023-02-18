/*
Задача 30: Напишите программу, которая выводит массив 
из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/ 

Console.Clear();

int Massive(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int ArrayLen = Massive("Введите длинну массива: ");

void Array()
{
    int[] Array = new int[ArrayLen];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(0, 2);
        Console.Write(Array[i] + " ");
    }
}
Array();
