// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m != 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine("Введите натуральное число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= 0 & n >= 0)
{
    Console.WriteLine($"Функция Аккермана для значений {m} и {n} равно: {Akkerman(m, n)}");
}
else Console.WriteLine("Числа должны быть неотрицательными");