// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
Console.WriteLine("Введите число– ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
int size = 0;
while (num > 0)
{
    num = num / 10;
    size = size + 1;
}
Console.WriteLine(size);

int symbol = 0;
int sum = 0;
for (int i = 0; i < size; i++)
{
    symbol = num1 % 10;
    num1 = num1 / 10;
    sum = sum + symbol;
}
Console.WriteLine(sum);


//Понимаю что мой код избыточен есть и альтенатива представлена ниже, но верхний написал сам, а нижний нашел на GitHub.
//Но мой код отдельно выводит колличество цифр в числе.(Хоть такой задачи не стояло) Да и использовал метод.заведения доп.переменной.

//Console.WriteLine("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int symbol;
//int result = 0;

//while (number>0)
//{
//    symbol = number%10;
//    number = number/10;
//    result = result+symbol;
//}
//Console.WriteLine(result);