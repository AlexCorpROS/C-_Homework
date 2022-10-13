// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int getSumStringArray(int[,] inputArray)
{
	int sum = 0;    
    int count = 0;
    int minSum = int.MaxValue;
    int minString = 0;
    for (int i = 0; i <= inputArray.GetLength(1); i++)
    {
		for (int j = 0; j < inputArray.GetLength(0) - 1; j++)
        {
			sum+= inputArray[i,j];            
		}        
        Console.WriteLine($"Сумма элементов {i} строки равна {sum}" );
        if(minSum > sum)
        {
            minSum=sum;
            minString = count;            
        }
        count++;             
        sum = 0;
	}
    return minString;
}

int[,] generatedArray = GenerateArray(5, 4, 100);
Console.WriteLine("Сгенерированный двумерный массив имеет вид : ");
showArray(generatedArray);
int strMaxSum = getSumStringArray(generatedArray);
Console.WriteLine("");
Console.WriteLine($"Сумма элементов {strMaxSum} строки исходного массива имеет минимальное значение ");