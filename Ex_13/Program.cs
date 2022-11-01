Console.Clear();

int InputNum(string num)
{
    Console.Write(num);
    return Convert.ToInt32(Console.ReadLine());
}

int numIn = InputNum($"Введите число: ");

if (numIn / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (numIn > 1000)
    {
        numIn = numIn / 10;
    }
    numIn = numIn % 10;
    Console.WriteLine($"Третья цифра: {numIn}");
}