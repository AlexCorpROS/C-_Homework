/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int getTestToZero(string Number)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(Number);
        string userLine = Console.ReadLine();
        int.TryParse(userLine,out result);
        if(result == 0 && userLine != "0") 
        {
            Console.WriteLine($"Введите целое число отличное от 0 вы ввели {userLine}");
        }
        else
        {
            break;
        }
    }
    return result;
}

int numberlength(int userNumber)
{
    userNumber = Math.Abs(userNumber);
    int result = (int)Math.Log10(userNumber) + 1;
    return result;
}

int getSumofdigitsinthenumber(int userNumber)
{
    int result = 0;
    int length = numberlength(userNumber);
    userNumber = Math.Abs(userNumber);
    for( int i = 0; i < length ; i++)
    {
        int valueSimbol = userNumber % 10;
        result += valueSimbol;
        userNumber /= 10; 
    }
    return result;
}

void getPrint(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}

getPrint("Введите число сумму знаков которого хотите найти : ",ConsoleColor.DarkGreen);
int userNumber = getTestToZero("");
getPrint($"Сумма знаков числа  {userNumber} равна {getSumofdigitsinthenumber(userNumber)}",ConsoleColor.DarkBlue);




