//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//N = 5, получаем массив [1, 2, 5, 7, 19]
//N = 3, получаем массив [6, 1, 33]

Console.Clear();
void FillArray(int[] collection)
{
    int length = collection.Length;
    for(int i = 0; i < length; i++)
    {
        collection[i]= new Random().Next(1, 10);
    }
}
void PrintArray(int[]col)
{
    int count = col.Length;
    for(int position = 0; position < count; position++)
    {
        Console.Write(col[position]);
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);
Console.WriteLine();
