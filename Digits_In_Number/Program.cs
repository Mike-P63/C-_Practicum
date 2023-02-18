/* Количество цифр в числе*/

Console.Clear();

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int getNumberOfDigits(int number)
{
    int numberOfDigit = 0;
    while(number > 0)
    {
        number = number/10;
        numberOfDigit++;
    }
    return numberOfDigit;
}
void showData(string messageStart, int data, string messageEnd)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
    Console.Write(messageEnd);
}

int number = getUserData("Введите число");
int numberOfDigit = getNumberOfDigits(number);
showData($"В числе {number} = ", numberOfDigit, $" чисел");
