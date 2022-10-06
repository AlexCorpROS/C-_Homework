// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задайте координату B1 для определения первой прямой :");
double B1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте координату K1 для определения первой прямой :");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте координату B2 для определения второй прямой :");
double B2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте координату K2 для определения второй прямой :");
double K2 = Convert.ToDouble(Console.ReadLine());

void printArray(double[] array) 
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

double[] getCooordinte(double B1, double K1, double B2, double K2)
{
    double[] Result = new double[2];    
    Result[0] = (B2 - B1) / (K1 - K2);    
    Result[1] = K1 * Result[0]+ B1;
    return Result; 
}

double[] Coordinat = getCooordinte(B1,K1,B2,K2);
Console.WriteLine("Координаты пересечения заданных прямых ");
printArray(Coordinat);

