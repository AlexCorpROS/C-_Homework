/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите три числа : ");
double number1 = Convert.ToDouble(Console.ReadLine());
double number2 = Convert.ToDouble(Console.ReadLine());
double number3 = Convert.ToDouble(Console.ReadLine());
double max = number1;

if(number2 > max)
{
    max = number2;
}
if(number3 > max)
{
    max = number3;
}
Console.WriteLine($"Максимальное из трех чисел = { max }");
