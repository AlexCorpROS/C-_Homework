// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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



/*
int getTestNumbertoZero(string userNumA, string userNumB)
{
    int resultA = 0;
    int resultB = 0;
    while (resultA == 0 && resultB < 0)
    {   
        Console.Write(userNumA);
        string userLineA = Console.ReadLine();
        Console.Write(userNumB);
        string userLineB = Console.ReadLine();
        int.TryParse(userLineA,out resultA);
        int.TryParse(userLineB,out resultB);
        if((resultA == 0 && userLineA != "0") && resultB < 0) 
        {
            Console.WriteLine($"На ноль делить нельзя. Введите другие значения");
        }
        else
        {
            break;
        }
    }
    resultA = Convert.ToInt32(resultA);
    resultB = Convert.ToInt32(resultB);
    return (resultA, resultB);
}

double getExponentiationNumAToB(double NumberA, double NumberB)
{
    double result = 0;
    result = Math.Pow(NumberA, NumberB);
    return result;
}

int userNumberA = 0;
int userNumberB = 0;
Console.WriteLine("Введите координаты");
userNumberAB = getTestNumbertoZero("A: ", "B: ");

//Console.WriteLine("Введите число которое хотите возвести в степень ");
//double userNumberA = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Введите степень в которую хотите возвести число {userNumberA} ");
//double userNumberB = Convert.ToDouble(Console.ReadLine());

double answer = getExponentiationNumAToB(userNumberA, userNumberB);
Console.WriteLine($"Число {userNumberA} возведенное в степень {userNumberB} равно {answer} ");

*/