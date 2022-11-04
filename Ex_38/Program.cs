// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

void FillArray(int[] collection)
{
    int array = collection.Length;
    for (int i = 0; i < array; i++)
    {
        collection[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] col)
{
    int size = col.Length;
    for (int position = 0; position < size; position++)
    {
        Console.Write($"{col[position]} ");
    }
}

int MaxArray(int[] array)
{
    int collection = array.Length;
    int Max = array[0];
    for (int i = 1; i < collection; i++)
    {
        if (array[i] > Max)
        {
            Max = array[i];
        }
    }
    return Max;
}

int MinArray(int[] array)
{
    int collection = array.Length;
    int Min = array[0];
    for (int i = 1; i < collection; i++)
    {
        if (array[i] < Min)
        {
            Min = array[i];
        }
    }
    return Min;
}

int Subs( int max, int min)
{
    int Sub = 0;
    Sub = max - min;
    return Sub;
}

int[] array = new int[7];
FillArray(array);
PrintArray(array);
int max = MaxArray(array);
int min = MinArray(array);
Console.WriteLine();
Console.WriteLine(Subs(max, min));
