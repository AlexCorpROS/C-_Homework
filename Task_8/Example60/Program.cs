// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[] getUserParamArray(string userValue)
{
    int[] userValue3dArray = new int[5];
    string[] paramArray = {"X","Y","Z", "минимального элемента массива", "максимального элемента массива"};
    for (int i = 0; i < userValue3dArray.Length; i++)
    {
        Console.Write($"Введите значение {paramArray[i]} : ");
        userValue3dArray[i]  = Convert.ToInt32(Console.ReadLine());
    }
    int arraySize = userValue3dArray[0]* userValue3dArray[1] *userValue3dArray[2];
    if((userValue3dArray[4] - userValue3dArray[3]) < arraySize)
    {        
        while((userValue3dArray[4] - userValue3dArray[3]) < userValue3dArray[0]*userValue3dArray[1]*userValue3dArray[2])
        {
            Console.WriteLine("Диапазон чисел меньше чем, размерность массива. Введите корректные значения");
            for (int i = 0; i < userValue3dArray.Length; i++)
            {
                Console.Write($"Введите значение {paramArray[i]} : ");
                userValue3dArray[i]  = Convert.ToInt32(Console.ReadLine());
            }
        }    
    }   
    return userValue3dArray;
}

void printArray(int[] incomingArray)
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

int[,,] getRandom3dArray(int[] userArrey)
{
  int[,,] array3D = new int[userArrey[0], userArrey[1], userArrey[2]];
  int[] temp = new int[userArrey[0] * userArrey[1] * userArrey[2]];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(userArrey[3], userArrey[4]+1);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(userArrey[3], userArrey[4]+1);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < userArrey[0]; x++)
  {
    for (int y = 0; y < userArrey[1]; y++)
    {
      for (int z = 0; z < userArrey[2]; z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
  return array3D;
}

void Write3DArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {      
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"({i}{j}{k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

Console.WriteLine("Задайте параметры трехмерного массива: ");
int[] userArrey = getUserParamArray("Введите значение :");
printArray(userArrey);
int[,,] array3D = getRandom3dArray(userArrey);
Write3DArray(array3D);