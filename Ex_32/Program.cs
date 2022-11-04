// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();
int arr1 = -4;
int arr2 = -8;
int arr3 = 8;
int arr4 = 2;
int[] array= { arr1, arr2, arr3, arr4 };
int size = array.Length;
for (int i = 0; i < size; i++)
{
    array[i] = -1 * array[i];
    Console.Write(array[i]);
    Console.Write(" ");
}
Console.WriteLine();
