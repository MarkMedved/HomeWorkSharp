// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
double x1, y1, z1, x2, y2, z2;
Console.WriteLine("Введите координаты первой точки x1:");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки y1:");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки z1:");
z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки x2:");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки y2:");
y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки z2:");
z2 = Convert.ToDouble(Console.ReadLine());
double path;
path = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {path}");
