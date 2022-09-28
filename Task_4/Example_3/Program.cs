/* Задача 29: Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33] */

Console.WriteLine("Введите желаемую длину массива :");
int userNumber = Convert.ToInt32(Console.ReadLine());
getPrint("Задайте минимальный диапазон значений в массиве :", ConsoleColor.Blue);
int MinMeaning = Convert.ToInt32(Console.ReadLine());
getPrint("Задайте максимальный диапазон значений в массиве :", ConsoleColor.Red);
int MaxMeaning = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[userNumber];
for (int i = 0; i < userNumber; i++)
{
    Array[i] = new Random().Next(MinMeaning, MaxMeaning +1);
}

void getPrint(string Text, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(Text);
    Console.ResetColor();
}

void printArray(int[] array) 
{
    Console.WriteLine("");
    getPrint($"Массив размером {userNumber} с диапазоном значений от {MinMeaning} до {MaxMeaning} включительно " , ConsoleColor.Green);
    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
           Console.Write(","); 
        }
    }
    Console.WriteLine("]");
    Console.WriteLine("");
}

printArray(Array);