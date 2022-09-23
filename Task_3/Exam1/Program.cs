// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Решенние методом Convert.ToString

int getNumberTest(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine,out result);
        if(result == 0 && userLine != "0") 
        {
            Console.WriteLine($"Введите целое число вы ввели {userLine}");
        }
        else
        {
            break;
        }
    }
    result = Math.Abs(result);
    return result;
}

int number = getNumberTest("Введите целое число ");
string text = Convert.ToString(number);
char[] obrtext = text.ToCharArray();
Array.Reverse(obrtext);
string converttext = new string(obrtext);
if(text==converttext)
{
    Console.WriteLine($"Введенное целое число является полиндромом");
}
if (text!=converttext)
{
    Console.WriteLine($"Введенное целое число не является полиндромом");
}




