// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели :");
int number = Convert.ToInt32(Console.ReadLine());
string[] DayWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

if (number == 6 ^ number == 7)
{
    Console.WriteLine($"{DayWeek[number -1]} выходной день");
}
else if (number > 0 && number < 6)
{
    Console.WriteLine($"{DayWeek[number -1]} будний день");
}
else
Console.WriteLine("У тебя странная неделя");
