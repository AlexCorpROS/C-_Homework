// Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

void printArray(int[] array) 
{
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
}

int[] getRandomArrey(int Number)
{
    int[] ResultArray = new int [Number];    
    for(int i = 0 ; i < Number ; i++)
    {
        Console.WriteLine($"Задайте значенния {i + 1} элемента массива");        
        ResultArray[i] = Convert.ToInt32(Console.ReadLine());    
    }        
    return ResultArray;
}

int[] getPairsOfNumbers(int[] UserArrey)
{
    double R =  UserArrey.Length/2.0;
    R = Math.Ceiling(R);
    Console.WriteLine($"размер нового массива равен {R} : ");
    int size = Convert.ToInt32(R);
    int[] CompositiontArray = new int [size];  
    int j =   UserArrey.Length -1 ;
    for (int i = 0; i < UserArrey.Length / 2.0; i++)
    {
        if (i == j)   // Если непарный элемент нужно перемножать на себя, то это условие удаляем.
        {
            CompositiontArray[i] = UserArrey[i];
            break;
        }
        CompositiontArray[i] = UserArrey[i] * UserArrey[j];
        j--;
    }
    return CompositiontArray;
}

Console.WriteLine("Введите длину массива : ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
int[] NewArrey = getRandomArrey(UserNumber);
Console.WriteLine("Полученный массив имеет вид : ");
printArray(NewArrey);
int[] ProductOfPairnumbers = getPairsOfNumbers(NewArrey);
Console.WriteLine("Массив полученный в результате произведения пар чисел исходного массива имеет вид : ");
printArray(ProductOfPairnumbers);
