// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int[,] getTrianglePascal(int row)
{
    int[,] triangle = new int[row, row];
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j < row; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
    return triangle;
}

void printTrianglePascal(int[,] userArray)
{
    const int indent = 3;
    int position = userArray.GetLength(0) * indent;
    for (int i = 0; i < userArray.GetLength(0); i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.SetCursorPosition(position, i+1);
            if (userArray[i, j] != 0)
            {
                Console.Write($"{userArray[i, j],indent}");
            }
            position += indent * 2;
        }
        position = indent * userArray.GetLength(0) - indent * (i - 1);
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
int[,] trianglePascalArray = getTrianglePascal(row);
Console.Clear();
printTrianglePascal(trianglePascalArray);

// Доработать определение значения отступа