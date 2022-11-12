// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int M = 5;
int N = 100;
int SumElem(int M, int N, int sum)
{
    if (M > N)
    {
        return sum;
    }
    sum = sum + (M++);
    return SumElem(M, N, sum);
}

Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна: {SumElem(M, N, 0)}");