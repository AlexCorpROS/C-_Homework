/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(double[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] getUserArray(int height,int width, double randomMin, double randomMax, int decimalplaces)
{
    double[,] RandomDoubleNumberArray = new double[height,width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Random random = new Random();   
            double temporaryRandom = Math.Round(random.NextDouble() * (randomMax - randomMin) + randomMin, decimalplaces );
            RandomDoubleNumberArray[i,j] = temporaryRandom;
        }
    }
    return RandomDoubleNumberArray;
}

double[,] UserArray = getUserArray(3,4,-500,+500, 2);
print2DArray(UserArray);
