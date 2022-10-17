/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

void PrintNumber(int n, int count)
{
    if (n > 0)
    {
        if (count > n) return;  
        PrintNumber(n, count + 1);
        Console.Write(count + ", ");
    }
    if (n <= 0)
    {
        if (count < n ) return;
        Console.Write(""+ n+ ", ");  
        PrintNumber(n+1, count);        
    }        
}

int userNumber(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int n = userNumber("Введите n: ");
int count = 2;
PrintNumber(n, count);
Console.Write(count-1);