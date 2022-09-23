// See https://aka.ms/new-console-template for more information
int number = Convert.ToInt32(Console.ReadLine());

int num = number/10;
double temp = num%Math.Pow(10, 5);
int Newnun = Convert.ToInt32(temp * Math.Pow(10, 3));

Console.WriteLine(temp);
//Console.WriteLine(Newnun);