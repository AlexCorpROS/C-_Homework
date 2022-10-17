/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

int userNumber(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int getSumOfRange(int M, int N)
{
    int Sum = M;
    if (M == N)
        return 0;
    if (M > N)
    {
        M++;
        Sum = N + getSumOfRange(N, M);        
        return Sum;
    }
    else
    {
        M++;
        Sum = M + getSumOfRange(M, N);
        return Sum;
    }
}

int M = userNumber("Введите значение M: ");
int N = userNumber("Введите значение N: ");
Console.Write($"Сумма элементов в диапазоне от {M} до {N} равна ");
Console.Write(getSumOfRange(M - 1, N));
