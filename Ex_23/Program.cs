//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write($"Введите число ");

int numIn = Convert.ToInt32(Console.ReadLine());
int num = 0;
int BigNum = 0;
while (num <= numIn)
{
    BigNum = num * num * num;
    num++;
    Console.WriteLine(BigNum);
}