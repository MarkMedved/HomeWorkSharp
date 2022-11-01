// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// (Использовать только математические операции, нельзя использовать число как строку по типу number[2])
// 20.10.2022 Sergey Dorofeev


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