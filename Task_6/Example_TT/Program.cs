//*Напишите программу, которая находит подмножество данного множества чисел такое, что сумма его элементов равна заданному числу
// 1,2,3,4,5    Число 7 = 3 + 4, 2 + 5, 1 + 2 + 4

Console.WriteLine("Задайте контрольное число для проверки: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество элементов множества: ");
int NumArray = Convert.ToInt32(Console.ReadLine());

void printArray(int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
           Console.Write(", "); 
        }
    }
    Console.WriteLine("]");
}

int[] getUserArray(int UserNumber)
{
    int[] UserArray = new int[UserNumber];
    for (int i = 0; i < UserNumber; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        UserArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return UserArray;
}

void sums(int[] arr, int target) {
    int[] stack = new int[arr.Length];
    int count = 0;

    void getTestSubSet(int i, int target) {                     
        if (target == 0) {
            for (int j = 0; j < count; ++j) 
            {
                Console.Write(stack[j] + " ");
            }
            Console.WriteLine();
            return;
        }
        if (i < arr.Length) {
            stack[count++] = arr[i];
            getTestSubSet(i + 1, target - arr[i]);
            --count;
            getTestSubSet(i + 1, target);
        }
    }

    getTestSubSet(0, target);
}

int[] TestArray = getUserArray(NumArray);
Console.WriteLine("Задано следующее множество ");
printArray(TestArray);
Console.WriteLine("Возможные подмножества, суммы которых равны контрольному числу : ");
sums(TestArray , Num);