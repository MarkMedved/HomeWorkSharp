//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
Console.WriteLine("Напиши число а");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напиши число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напиши число с");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max>b)
    {
    max = a;
    }
    else
    {
    max = b;
    }
if (max > c)
    {
    Console.Write("max= ");
    Console.WriteLine(max);
    }
else
    {
    max = c;
    Console.Write("max= ");
    Console.WriteLine(max);
    }