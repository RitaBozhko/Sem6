// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine("Введите 4 числа, они станут коэффициентами двух линейных уравнений.");
Console.WriteLine("Введите число: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число: ");
double b2 = double.Parse(Console.ReadLine()!);


void FindWhereLinesCross(double k1, double b1, double k2, double b2)
{
    if (k1==k2) Console.WriteLine("Прямые параллельны, точек пересечения нет.");
    else
    {
        double x = (b2 - b1)/(k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Прямые пересекутся в точке с координатами ({x}, {y}).");
    }
}

FindWhereLinesCross(k1,b1,k2,b2);