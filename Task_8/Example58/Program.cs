// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GenerateArray(int height, int weight, int value)
{
    int[,] generatedArray = new int[height, weight];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i, j] = new Random().Next(0, value);
        }
    }
    return generatedArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void showArray(int[,] inputArray)
{
    printColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j].ToString()}\t");
        }
        Console.WriteLine();
    }
}

int[,] productTwoMatrices(int[,] inputFirstArray, int[,] inputSecondArray)
{
    int[,] outputMatrices = new int[inputFirstArray.GetLength(0), inputFirstArray.GetLength(1)];
    if (inputFirstArray.GetLength(1) == inputSecondArray.GetLength(0))
    {
        for (int i = 0; i < outputMatrices.GetLength(0); i++)
        {
            for (int j = 0; j < outputMatrices.GetLength(1); j++)
            {
                outputMatrices[i, j] = 0;
                for (int k = 0; k < inputFirstArray.GetLength(1); k++)
                {
                    outputMatrices[i, j] += inputFirstArray[i, k] * inputSecondArray[k, j];
                }
            }
        }
    }
    return outputMatrices;
}


int[,] generatedArray = GenerateArray(2, 2, 10);
Console.WriteLine("Сгенерированный двумерный массив имеет вид : ");
showArray(generatedArray);
int[,] generatedArray2 = GenerateArray(2, 2, 10);
Console.WriteLine("Сгенерированный двумерный массив имеет вид : ");
showArray(generatedArray2);
int[,] test = productTwoMatrices(generatedArray,generatedArray2);
Console.WriteLine("");
Console.WriteLine("Произведение исходных массивов имеет вид : ");
showArray(test);
