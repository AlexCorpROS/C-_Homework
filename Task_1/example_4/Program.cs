/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (num == 0 | num == 1 | num < 0)
{
    Console.WriteLine("Нет чётных чисел!");
}
else
{
    Console.WriteLine("Чётные числа от 1 до " + num);
    while (i <= num)
    {
        if (i % 2 != 1)
        {
        Console.Write(i + " ");
        }
        i++;
    }
}
