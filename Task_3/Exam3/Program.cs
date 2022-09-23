// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int getNumberFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result) || result < 1) // result < 1 если без массива, result <= 1 для массива
    {
        Console.Write($"Ошибка ввода! Ожидается целое число больше единицы. {userInformation} ");
    }
    return result;
}
/* Решение через массив

int[] tableofcubes(int number)
{
    int[] result = new int [number];
    for(int i = 1; i <= number; i++)
    {
        result[i - 1] = (int)(Math.Pow(i, 3));
    }
    return result;
} 

int number = getNumberFromUser("Введите целое число N > 1 : ");
int[] table = tableofcubes(number);
// Через for
for (int i = 1; i < table.Length; i++)
{
    Console.Write(table[i] + " ");
}
*/

/* Решение через foreach выдвает лишнюю единицу
foreach (var value in table)
{
    Console.Write(value + " ");
} */

// Решение через for без массива

int tableofcubes(int number)
{
    int table = 0 ;
    Console.WriteLine("");
    Console.WriteLine($"Таблица кубов числел от 1 до {number} выглядит так ");
    Console.WriteLine("");
    for(int i = 1; i <= number; i++)
    {
        table = Convert.ToInt32(Math.Pow(i, 3));
                Console.Write($"{table} ");
    }
    return table;
}

int number = getNumberFromUser("Введите целое число N > 0 : ");
int nn = tableofcubes(number);
//