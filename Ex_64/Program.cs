// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int N = 10;

void AllNumbers(int N)
{
    if (N==0) return;
    Console.Write($"{N} ");
    AllNumbers(N-1);
}
if(N<1) Console.WriteLine("Введите число > 0");
else AllNumbers(N);