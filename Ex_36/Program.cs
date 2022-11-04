// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

void FillArray (int[] collection)
{
    int length = collection.Length;
    for(int i = 0; i< length; i++)
    {
        collection[i]= new Random().Next(1, 100);
    }
}
void PrintArray (int[] col)
{
    int size = col.Length;
    for(int position = 0; position < size; position++)
    {
        Console.Write($"{col[position]} ");
    }
}
int SummaPositions (int [] array)
{
    int length = array.Length;
    int summa = 0;
    for( int i =0; i<length; i++)
    {
        if(array[i]%2!=0)
        {
            summa = summa + array[i];
        }
    }
    return summa;
}
int [] array =new int [8];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int all = SummaPositions(array);
Console.WriteLine ($"Сумма нечетных чисел = {all}");
