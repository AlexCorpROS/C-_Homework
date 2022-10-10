/* Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9 */

int[,] getRandomArray(int height, int width, int minValue, int maxValue)
{
    int[,] randomArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            randomArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return randomArray;
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
}

int getTestPositionElement(int[,] userArray, int userNumber)
{
    if (userNumber > userArray.Length)
    {
        Console.WriteLine("Элемента с такой позицией в данном массиве нет");
    }
    else
    {
        int i = userNumber / userArray.GetLength(1);
        if(userNumber%userArray.GetLength(1) != 0)
        {
        int j = userNumber - userArray.GetLength(1)*i -1 ;        
        Console.WriteLine($"{userNumber} элемент массива имеет значеие {userArray[i , j]}");
        }
        else
        {
            int j = userNumber - (userArray.GetLength(1))*(i-1) -1 ;            
            Console.WriteLine($"{userNumber} элемент массива имеет значеие {userArray[i -1 , j]}");
        }
    }
    return userNumber;
}

Console.WriteLine("Введите искомый элемент массив: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[,] userArray = getRandomArray(7, 3, 1, 100);
print2DArray(userArray);
int NumberElement = getTestPositionElement(userArray, userNumber);
