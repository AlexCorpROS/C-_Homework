// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
void printArray(double[] array) 
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

double[] getRandomArrey(int Number)
{
    double[] ResultArray = new double [Number];    
    for(int i = 0 ; i < Number ; i++)
    {
        Console.WriteLine($"Задайте значенния {i + 1} элемента массива");
        double buff = Convert.ToDouble(Console.ReadLine());
        ResultArray[i] = buff;        
    }        
    return ResultArray;
}

double getDifferenceMinMaxElementsArrey(double[] UserArrey)
{
    int i =0;
    double result = 0;
    double min = UserArrey[i];
    double max = UserArrey[i];
    for ( i = 0 ; i < UserArrey.Length; i++)
    {
        if(UserArrey[i] < min)
        {
            min = UserArrey[i];
        }
        if(UserArrey[i] > max)
        {
            max = UserArrey[i];
        }
    }
    Console.WriteLine($"Минимальный элемент массива равен {min}");
    Console.WriteLine($"Максимальный элемент массива равен {max}");
    result = max - min;
    return result;
}

Console.WriteLine("Введите длину массива : ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
double[] NewArrey = getRandomArrey(UserNumber);
Console.WriteLine("Полученный массив имеет вид : ");
printArray(NewArrey);
double different = getDifferenceMinMaxElementsArrey(NewArrey);
Console.WriteLine($"Разница между максимальнным и минимальным значениями массива равна {different}");


