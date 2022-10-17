// Задача о друзьях и собаке
Console.WriteLine("Какое растояние между друзьями ? : ");
double distance = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Какая скорость первого друга ? : ");
double FirstSpeed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Какая скорость второго друга ? : ");
double SecondSpeed = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Какая скорость собаки ? : ");
double DogSpeed = Convert.ToInt32(Console.ReadLine());

int friend = 2;
int count = 0;

while(distance > 10)
{

    if(friend == 1)
    {
        double time = distance / (FirstSpeed + DogSpeed);
        friend = 2;
        distance = distance - (FirstSpeed + SecondSpeed) * time;
    }

   else
    {
        double time = distance / (SecondSpeed + DogSpeed);
        friend = 1;
        distance = distance - (FirstSpeed + SecondSpeed) * time;
    }

count += 1;

}

Console.Write("Собака успела пробежаться " + count +" раз.");


