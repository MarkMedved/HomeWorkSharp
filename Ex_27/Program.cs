// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int symbol;
int result = 0;

while (number>0)
{
   symbol = number%10;
   number = number/10;
   result = result+symbol;
}
Console.WriteLine(result);