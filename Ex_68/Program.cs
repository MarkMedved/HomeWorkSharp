// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int m = 5;
int n = 100;

if (m >= 0 & n >= 0)
{
    Console.WriteLine($"Функция Аккермана для значений {m} и {n} равно: {Akkerman(m, n)}");
}
else Console.WriteLine("Введите ннеотрицательные числа");

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m != 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}