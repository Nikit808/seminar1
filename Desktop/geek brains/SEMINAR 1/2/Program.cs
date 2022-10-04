// Задача 2. Найти максимум из двух чисел

Console.Clear();

Console.WriteLine("Введите число a: "); 
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b: "); 
int b = int.Parse(Console.ReadLine()!);
if(a>b)
{
    Console.Write($"max={a}, min={b}");
}
else
{
    Console.Write($"max={b}, min={a}");
}
