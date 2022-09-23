// See https://aka.ms/new-console-template for more information

int getSize(int num)
{
    string Size = Convert.ToString(num);
    int size = Size.Length;
    return size;
}
int getObrez(int num,int size)
{
    int Newnum = num;
    int i = 1;
    double temp = 0;
    while(i < size )
    {
        Newnum /= 10;
        temp = Newnun%Math.Pow(10,size -2);
        Newnum = temp;
        i++;
        size-= 2;
    }
    return Newnun;
}

int num = Convert.ToInt32(Console.ReadLine());
int size = getSize(num);
double FirstSign =Convert.ToInt32(num/Math.Pow(10,size -1));
int LastSign = num%10;
int Newnun1 = getObrez(num, size);


Console.WriteLine($"{FirstSign} , {LastSign} , {Newnun1} ");
