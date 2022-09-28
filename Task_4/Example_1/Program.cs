// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
double getExponentiationNumAToB(double NumberA, double NumberB)
{
    double result = 0;
    result = Math.Pow(NumberA, NumberB);
    return result;
}

Console.WriteLine("Введите число которое хотите возвести в степень ");
double userNumberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите степень в которую хотите возвести число {userNumberA} ");
double userNumberB = Convert.ToDouble(Console.ReadLine());

double answer = getExponentiationNumAToB(userNumberA, userNumberB);
Console.WriteLine($"Число {userNumberA} возведенное в степень {userNumberB} равно {answer}");

*/

/* Решенние с циклом

Console.WriteLine("Введите число которое хотите возвести в степень ");
double userNumberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите степень в которую хотите возвести число {userNumberA} ");
double userNumberB = Convert.ToDouble(Console.ReadLine());
double answer = 1;
for(int i = 1; i <= userNumberB ; i++)
{
    answer = answer * userNumberA ;
}
Console.WriteLine($"Число {userNumberA} возведенное в степень {userNumberB} равно {answer}");
*/

/* решение через проверку массивом 

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

// Решение через условие if

int GetExp (int number, int exp) {
    int prod = 1;
    for (int i = 1; i <= exp; i++)
        prod *= number;
    return prod;
}


void Input () {
    Console.Write ("Введите число: ");
    int a = int.Parse (Console.ReadLine ());
    Console.Write ("И показатель степени в которую нужно возвести это число: ");
    int b = int.Parse (Console.ReadLine ());

    
    if (a == 0 && b < 0) {
        Console.WriteLine ("Вы ввели не корректное число");
        Input();
        return;
    }

    Console.WriteLine ($"{a}^{b} = {GetExp (a, b)}");
}

Input();