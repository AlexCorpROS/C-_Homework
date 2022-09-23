﻿// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/* Решенние методом Convert.ToString

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

string getConvertToString(int number)
{
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
    return text;
}

int number = getNumberTest("Введите целое число ");
string answer = getConvertToString(number);
*/

/* Решенние методом for()
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

bool getPalindromeTest(string number)
{
    for (int i = 0; i < number.Length / 2; i++)
        if (number[i] != number[number.Length -i -1])
                    return false;                              
        return true;
        
}
int number = getNumberTest("Введите целое число ");
bool answer = getPalindromeTest(Convert.ToString(number));

if(answer == true)
{   
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number}  не является палиндромом");
}
 */

 // Математическое решение
           