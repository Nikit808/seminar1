// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
double  result(int a, int b)
{
    double result; 
    result=Math.Pow(a,b);
    return result;
}

Console.Write("Введите число: A ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число: B ");
int b = int.Parse(Console.ReadLine()!);

Console.Write($"Произведение числа {a} в степени {b} = {result(a,b)}");

