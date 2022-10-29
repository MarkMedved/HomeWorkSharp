// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Напиши переменную a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напиши перевенную b");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max > b)
{
    max = a;
}
else
{
    max = b;
}
Console.Write("max = ");
Console.WriteLine(max);
