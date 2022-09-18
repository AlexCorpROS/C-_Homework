/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите первое число : ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
double number2 = Convert.ToDouble(Console.ReadLine());

if(number1 == number2)
Console.WriteLine("Числа равны между собой");

else if(number1 > number2)
{
    Console.WriteLine($"Первое число больше второго и равно = {number1}");
    Console.WriteLine($"Второе число меньше первого и равно = {number2}");
}    
else
{
    Console.WriteLine($"Второе число больше первого и равно = {number2}");
    Console.WriteLine($"Первое число меньше второго и равно = {number1}");
}   