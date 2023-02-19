/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(message);
    Console.ResetColor();
    return int.Parse(Console.ReadLine()!);
}

int number = getUserData("Введите число, состоящее из нескольких цифр: ");

void SumOfNumbers(int n, int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

SumOfNumbers(number, number);