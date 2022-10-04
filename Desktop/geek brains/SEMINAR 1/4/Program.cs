// Задача 2. Найти максимум из трех чисел

Console.Clear();

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число d: ");
int d = int.Parse(Console.ReadLine()!);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (d > max) max = d;

Console.Write ("max = ");
Console.WriteLine (max);

