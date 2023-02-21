
/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
 Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

string Fibonachi(int number)
{
    int n1 = 0;
    int n2 = 1;
    string result = $"{n1}{n2}";
    for (int i = 0; i < number - 2; i++)
    {
        int n = n1 + n2;
        result = result + n;
        n1 = n2;
        n2 = n;
    }
    return result;
}
int number = getUserData("Введите число:");
string result = Fibonachi(number);
Console.WriteLine(result);