/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int userNumber(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int getAkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return getAkkermanFunc(m - 1, 1);
    }
    else
    {
        return (getAkkermanFunc(m - 1, getAkkermanFunc(m, n - 1)));
    }
}

int M = userNumber("Введите значение M: ");
int N = userNumber("Введите значение N: ");
int value = getAkkermanFunc(M,N);
Console.WriteLine($"Значение функции Аккермана для чисел {M} и {N} равно {value}");