// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

void FillArray(double[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(1, 100);
    }
}

void PrintArray(double[] col)
{
    for (int position = 0; position < col.Length; position++)
    {
        Console.Write($"{col[position]} ");
    }
}

double MaxArray(double[] array)
{
    double Max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > Max)
        {
            Max = array[i];
        }
    }
    return Max;
}

double MinArray(double[] array)
{
    double Min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < Min)
        {
            Min = array[i];
        }
    }
    return Min;
}

double Subs( double max, double min)
{
    double Sub = 0;
    Sub = max - min;
    return Sub;
}

double[] array = new double [7];
FillArray(array);
PrintArray(array);
double max = MaxArray(array);
double min = MinArray(array);
Console.WriteLine();
Console.WriteLine(Subs(max, min));
