// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine();
Console.Clear();

int[,] matrix = new int[8, 8];

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int WriteNumM()
{
    Console.WriteLine("Веедите номер строки: ");
    int m = Convert.ToInt32(Console.ReadLine());
    return m;
}

int WriteNumN()
{
    Console.WriteLine("Веедите номер столбца: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

bool FindNumberMatrix(int m, int n, int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (m <= matrix.GetLength(0) && n <= matrix.GetLength(1))
                return true;
        }
    }
    return false;
}

void PrintResult(int m, int n, int[,] matrix, bool result)
{
    if (result)
        Console.WriteLine($"На позиции {m},{n} элемент {matrix[m - 1, n - 1]}");
    else
        Console.WriteLine("Такого элемента в массиве нет");
}

FillMatrix(matrix);
PrintMatrix(matrix);
int m = WriteNumM();
int n = WriteNumN();
bool result = FindNumberMatrix(m, n, matrix);
PrintResult(m, n, matrix, result);