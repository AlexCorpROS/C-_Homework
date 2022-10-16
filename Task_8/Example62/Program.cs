// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] getSpiralNumberArray(string userValue)
{
    Console.Write($"Введите значение длины массива : ");
    int value  = Convert.ToInt32(Console.ReadLine());
    int[,] outputArray = new int[value, value];
    int i = 0; int j = 0; int temp = 1;
    while (temp <= outputArray.GetLength(0) * outputArray.GetLength(1))
    {
        outputArray[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < outputArray.GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= outputArray.GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > outputArray.GetLength(1) - 1)
        j--;
        else
        i--;
    }
    return outputArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] spiralArray = getSpiralNumberArray("Введите значение :");
print2DArray(spiralArray);