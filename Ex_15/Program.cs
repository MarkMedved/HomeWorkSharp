Console.Clear();
Console.WriteLine("Введите трехзначное число");
int num = Convert.IoInt32(Console.ReadLine());
int x1 = num % 100;
int x2 = x1 / 10;
Console.WriteLine("Вторая строая цифра числа" + x2);
