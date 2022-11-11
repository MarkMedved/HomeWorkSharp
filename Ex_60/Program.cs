// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

Console.WriteLine("Введите длину куба (n): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ширину куба (n): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите высоту куба (l): ");
int l = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[n, m, l];
int vol=n*m*l;
if(vol<91)
{
RandomMatrix(matrix, Generator(vol));
PrintMatrix(matrix);
}
else Console.WriteLine("Количество элементов матрицы больше количесва двузначных элементов");

void RandomMatrix(int[,,] matrix, int[] mass)
{
    int l=0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = mass[l];
                l++;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})"+"\t");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] Generator(int m3)
{
    Random rnd = new Random();
    int[] a = new int[m3];
    a[0] = rnd.Next(10, 100);
    for (int i = 1; i < a.Length;)
    {
        int num = rnd.Next(10, 100); // генерируем элемент
        int j;
        // поиск совпадения среди заполненных элементов
        for (j = 0; j < i; j++)
        {
            if (num == a[j])
                break; // совпадение найдено, элемент не подходит
        }
        if (j == i)
        { // совпадение не найдено
            a[i] = num; // сохраняем элемент
            i++; // переходим к следующему элементу
        }
    }
    return a;
}
