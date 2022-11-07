// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}

int CountPositive(int[] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Clear();

Console.WriteLine ("Введите числа через запятую: ");

string input = Console.ReadLine()!;

int[] numArray = GetArrayFromString(input);

int count = CountPositive(numArray);
Console.WriteLine($"Чисел больше нуля: {count}");