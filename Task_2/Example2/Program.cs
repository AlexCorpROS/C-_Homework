// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int getNumbertothreedigit(int number)
{
    int result = new int();
    while(number > 1000 | number < -1000 )
    {
        number /= 10;
    }
    result = number % 10;
    if(result < 0)
    {
        result *= -1;
    }    
    return result;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 && number > -100)
Console.WriteLine("Третьей цифры нет");
else
{
    int num = getNumbertothreedigit(number);
    Console.WriteLine(num);    
}
