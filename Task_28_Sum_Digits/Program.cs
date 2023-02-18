/*
Задача 28: Напишите программу, которая принимает на вход 
число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int sumDigits(int start, int end)
{
    int sum = 1;
    for (int i = 1; i <= end; i++)
    {
        sum = sum * i;
    }
    return sum;
}


int number = getUserData("Введите число");
int result = sumDigits(1, number);

Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");


