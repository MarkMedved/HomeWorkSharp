Console.Clear();
int InputNum(string num)
{
    Console.WriteLine(num);
    return Convert.ToInt32(Console.ReadLine());
}

int numIn = InputNum($"Введите день недели в виде цифры: ");
if (numIn <= 7)
{
    if (numIn == 7 || numIn == 6)
{
    Console.WriteLine("Ура выходной!");
}
else
{
    Console.WriteLine("Рабочий день недели :(");
}
}
else
{
    Console.WriteLine("Введите корректную цифру!");
}