// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.WriteLine("Enter b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double X = FindIntersectionX(b1, k1, b2, k2);
double Y = FindIntersectionY(k1, b1, X);
PrintIntersection(b1, k1, b2, k2, X, Y);
double FindIntersectionX(double b1, double k1, double b2, double k2)
{
    double x = 0;
    return x = (b2 - b1) / (k1 - k2);
}

double FindIntersectionY(double k1, double b1, double X)
{
    double y = 0;
    return y = k1 * X + b1;
}

void PrintIntersection(double b1, double k1, double b2, double k2, double X, double Y)
{
    if ((k1 * X + b1) == (k2 * Y + b2))
    {
        Console.WriteLine("Point of intersection: ");
        Console.WriteLine($"({X},{Y})");
    }
    else {Console.WriteLine("There is no intersection.");}
}



