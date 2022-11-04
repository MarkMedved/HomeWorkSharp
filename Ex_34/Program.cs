// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] col)
{
    int size = col.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{col[i]} ");
    }
}
int EvenCount(int[] array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int all = EvenCount(array);
Console.WriteLine($"Всего четных чисел – {all}");