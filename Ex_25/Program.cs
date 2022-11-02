//Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//без использования math.pow

Console.Clear();

int Degree(int A, int B)
{
    int result = A;
    for(int i =1; i< B; i++)
    {
        result = result * A;
    }
    return result;
}
int output = Degree(5,1);
Console.WriteLine(output);