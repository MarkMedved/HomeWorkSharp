Console.Clear();
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int StartNumber = 1;

while (StartNumber <= N)
{ 
    if (StartNumber % 2 == 0)
    {
        Console.WriteLine(StartNumber);
    }
    StartNumber += 1;
}