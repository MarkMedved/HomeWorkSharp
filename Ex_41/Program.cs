// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
int[] GetData(string text)
{
    Console.WriteLine(text);
    string[] arg;
    while (true)
    {
        arg = Console.ReadLine().Split(new char[] { ' ', ',', '|' }, StringSplitOptions.RemoveEmptyEntries);
        if (arg.Length > 0) break;
    }
    int size = arg.Length;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        int output;
        if (int.TryParse(arg[i], out output))
            result[i] = output;
        else result[i] = -1;
    }
    return result;
}
int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        sum++;
    }
    return sum;
}
void PrintSumma(int sum)
{
    Console.WriteLine(sum);
}

int[] array = GetData("Введите числа через пробел– ");
Console.WriteLine(String.Join("_", array));
int sum = Sum(array);
PrintSumma(sum);