// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int a)
{
    int Sum = 0;
    while (a != 0)
    {
        Sum =Sum + a%10;
        a=a/10;
    }
return Sum;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(n));