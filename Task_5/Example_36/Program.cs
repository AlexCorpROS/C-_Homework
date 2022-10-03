// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] getRandomArrey(int Number, int min , int max)
{
    int[] ResultArray = new int [Number];
    var rnd = new Random();
    Console.WriteLine($"Полученный рандомный массив чисел диапазона от {min} до {max} длинной {Number}");
    for(int i = 0 ; i < Number ; i++)
    {
        ResultArray[i] = rnd.Next(min, max + 1);
        Console.Write($"{ResultArray[i]} ");
    }
    Console.WriteLine("");
    return ResultArray;
}

int getSumOddPositionElements(int[] UserArrey)
{
    int Sum = 0;
    for (int i = 1; i < UserArrey.Length; i+= 2)
    {
        Sum += UserArrey[i];
    }
    return Sum;
}

Console.WriteLine("Введите длину массива : ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальнное знначение элементов массива :");
int Usermin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальнное знначение элементов массива :");
int Usermax = Convert.ToInt32(Console.ReadLine());

int[] UserArrey = getRandomArrey( UserNumber, Usermin , Usermax );
int Summa = getSumOddPositionElements(UserArrey);
Console.WriteLine($"Сумма нечетных элементов рандомного массива длиной {UserNumber} элемента равна {Summa}");