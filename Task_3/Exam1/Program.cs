// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

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

 /* Решение методом реверс
         
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

int reverse_number(int number)
{
    int n = 0;
    while(number > 0)
    {
        n = 10*n + number%10;
        number /= 10;
    }

 return n;
}
int number = getNumberTest("Введите целое число ");
int n = reverse_number(number);
if(number == n)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else 
Console.WriteLine($"Число {number} не является палиндромом");
*/

// Решение математическим методом

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
    return result;  
}

int getSize(int num)
{
    string Size = Convert.ToString(Math.Abs(num));
    int size = Size.Length;
    return size;
}

int getPalindromTest(int num , int size)
{
    int i = 0;
    int Newnum = Math.Abs(num);
    double temp = 0;
    while( i <= size )
    {
        double FirstSign = Convert.ToInt32(Newnum/Math.Pow(10,size -1));
        int LastSign = Newnum%10;
        Newnum /= 10;
        temp = Newnum%Math.Pow(10,size -2);
        Newnum = Convert.ToInt32(temp);
        
        if(FirstSign == LastSign )
        {
            i++;
            size -= 2;
        }
        else
        {
            break;
        }
    }
        return i;
}

int num = getNumberTest("Введите целое число :");
int size = getSize(num);
double answer = getPalindromTest(num, size);

if(answer == 0)
{
    Console.WriteLine($"Число {num} не палиндром");
}
else
{
    Console.WriteLine($"Число {num} палиндром");
}

//Console.WriteLine(userInformation);

