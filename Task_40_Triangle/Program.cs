/*Задача 40: Напишите программу, которая принимает на вход 
три числа и проверяет, может ли существовать треугольник с 
сторонами такой длины. Теорема о неравенстве треугольника: 
каждая сторона треугольника меньше суммы двух других сторон
*/
Console.Clear();

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
bool IsTriangleExist(int a, int b, int c)
{
    bool isExist = false;
    if (a < b + c && b < c + a && c < b + a)
    {
        isExist = true;
    }
    return isExist;
}
int a = getUserData("Введите длину стороны а");
int b = getUserData("Введите длину стороны b");
int c = getUserData("Введите длину стороны c");
bool isExist = IsTriangleExist(a, b, c);
Console.WriteLine($"Треугольник со сторонами [{a},{b},{c}] {((isExist) ? "exist" : "not exist")}");
