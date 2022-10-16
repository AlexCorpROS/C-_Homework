// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void show2DArray(int[,] inputArray)
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

int[] getSortArray(int[] inputArray)
{
	for (int i = 0; i < inputArray.Length; i++)
    {
		for (int j = 0; j < inputArray.Length - 1; j++)
        {
			if (inputArray[j] < inputArray[j + 1])
			{
				int t = inputArray[j + 1];
				inputArray[j + 1] = inputArray[j];
				inputArray[j] = t;
            }
		}
	}
    return inputArray;
}

int[,] getSortDescendingOrder(int[,] inputArray)
{
    int max = inputArray[0,0];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int[] tempArray = new int[inputArray.GetLength(1)];
        
        for (int j = 0; j < inputArray.GetLength(1); j++)    
        {
            tempArray[j] = inputArray[i,j];
        }
        int[] sortedArray = getSortArray(tempArray);
        for (int j = 0; j < inputArray.GetLength(1); j++)    
        {
            inputArray[i,j] = sortedArray[j];
        }        
    }
    return inputArray;
}

int[,] generatedArray = GenerateArray(5, 4, 100);
Console.WriteLine("Сгенерированный двумерный массив имеет вид : ");
show2DArray(generatedArray);
int[,] sortedArray = getSortDescendingOrder(generatedArray);
Console.WriteLine("Отсортированный массив имеет вид : ");
show2DArray(sortedArray);


