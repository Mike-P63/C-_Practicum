/*Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

Console.Clear();

int[] generetArray(int length, int deviation)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-deviation, deviation + 1);
    }
    return array;
}
void printArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("[ ");
    Console.ResetColor();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(" ]");
    Console.ResetColor();
    Console.WriteLine();
}
int[] reverseArray(int[] array)
{
    int fulllength = array.Length;
    int length = array.Length / 2;
    for (int i =0; i < length; i++)
    {
        int buf = array[i];
        array[i] = array[fulllength - i - 1];
        array[fulllength - i - 1] = buf;
    }
    return array;
}
int[] array = generetArray(10,20);
printArray(array);
Console.WriteLine();
int[] reversed = reverseArray(array);
printArray(reversed);
Console.WriteLine();