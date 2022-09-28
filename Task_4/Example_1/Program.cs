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