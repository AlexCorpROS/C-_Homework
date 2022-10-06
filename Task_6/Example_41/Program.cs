// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.Write("Какое количество чисел вы хотите ввести : ");
int UserNumber = Convert.ToInt32(Console.ReadLine());

void printArray(int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
           Console.Write(", "); 
        }
    }
    Console.WriteLine("]");
}

int[] getUserArray(int UserNumber)
{
    int[] UserArray = new int[UserNumber];
    for (int i = 0; i < UserNumber; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        UserArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return UserArray;
}

int getPoositivNum(int[] UserArray)
{
    int count =0;
    for (int i = 0; i < UserArray.Length; i++)
    {
        if(UserArray[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

int[] TestArray = getUserArray(UserNumber);
Console.WriteLine("Вы ввели следующие цифры");
printArray(TestArray);
int SumPositivNum = getPoositivNum(TestArray);
Console.WriteLine($"Среди введенных вами чисел {SumPositivNum} больше нуля");