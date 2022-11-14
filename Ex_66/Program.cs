// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число от которого считать:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число до которого считать:");
int N = Convert.ToInt32(Console.ReadLine());

int SumElem (int m, int n, int sum)
{
    if (m > n) 
    { 
        return sum;
    }
    sum = sum + (m++);
    return SumElem(m, n, sum);
}

Console.WriteLine($"Сумма от натуральных чисел от {M} до {N} равна: {SumElem(M, N, 0)}");