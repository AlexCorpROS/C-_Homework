//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] getRandomArrey(int UserNumber)
{
    int[] UserArray = new int [UserNumber];
    var rnd = new Random();
    Console.WriteLine($"Полученный рандомный массив трехзначных чисел длинной {UserNumber}");
    for(int i = 0 ; i < UserNumber ; i++)
    {
        UserArray[i] = rnd.Next(100, 1000);
        Console.Write($"{UserArray[i]} ");
    }
    Console.WriteLine("");
    return UserArray;
}

int getCountPositivNumbers(int[] UserArrey)
{
    int count = 0;
    for (int i = 0; i < UserArrey.Length; i++)
    {
        if(UserArrey[i] % 2 == 0)
        {
            count++;
        }        
    }    
    return count;
}

Console.WriteLine("Введите длину массива : ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
int[] RR = getRandomArrey(UserNumber);
int CountPositiv = getCountPositivNumbers(RR);
Console.WriteLine($"В этом массиве {CountPositiv} четных числа");
























/*
void getPrint(string Text, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(Text);
    Console.ResetColor();
}
int[] getTestToCorrect(string Number,string St )
{
    int[] userNumbers = new int[2];
    int resultA = 0;
    int resultB = -1;
    while (resultA == 0 && resultB < 0)
    {
        Console.Write("Введите число которое хотите возвести в степень : ");        
        string number = Console.ReadLine();
        int.TryParse(number,out resultA);
        
        Console.Write("Введите степень в которую хотите возвести число : ");        
        string st = Console.ReadLine();
        int.TryParse(st,out resultB);
        if(resultA == 0 && resultB < 0) 
        {
            getPrint($"Измените один из параметров. На ноль делить нельзя ", ConsoleColor.Red);
            Console.WriteLine("");
        }
        else
        {
            break;
        }
    }
    userNumbers[0] = resultA;
    userNumbers[1] = resultB;
    return userNumbers;
}

int[] Arr = getTestToCorrect("Введите число А:"," Введите число B: ");
double answer = 1;
for(int i = 1; i <= Arr[1] ; i++)
{
    answer = answer * Arr[0] ;
}
Console.WriteLine("");
getPrint($"Число { Arr[0] } возведенное в степень {Arr[1]}  равно {answer} ", ConsoleColor.Cyan);
*/

