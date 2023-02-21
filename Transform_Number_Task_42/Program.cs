/*
Задача 42: Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10.
*/

Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
string TransformBinary(int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number = number / 2;
    }
    return result;

}
int number = getUserData("Введите число");
string binary = TransformBinary(number);
Console.WriteLine($"Число {number} в двоичной системе = {binary}");

