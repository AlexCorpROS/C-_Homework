/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

void printArray(double[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
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

double[] getAverageStringArray(int[,] userArray, int userValue)
{
    double[] result = new double[userArray.GetLength(1)];    
    double Sum = 0;
    for (int j = 0; j < userArray.GetLength(1); j++)
    {
        for (int i = 0; i < userArray.GetLength(0); i++)
        {
            Sum += userArray[i,j];            
        }
        double temp = Sum/userArray.GetLength(0);
        result[j] = Math.Round(temp, userValue);
        Sum = 0;
    }
    return result;
}

Console.WriteLine("Сколько знаков после запятой распечатывать : ");
int userValue = Convert.ToInt32(Console.ReadLine());

int[,] userArray = getRandomArray(7, 3, 1, 100);
print2DArray(userArray);
double[]  averString = getAverageStringArray(userArray, userValue);
Console.WriteLine("Сколько знаков после запятой распечатывать : ");
printArray(averString);