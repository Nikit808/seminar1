// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int N2 = 2;
Console.Write("Четные Числа: ");
while (N2 <= N)
{
    Console.Write($"{N2} ");
    N2 = N2 + 2; 
}