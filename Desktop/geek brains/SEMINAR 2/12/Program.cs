// задача про кратность 

Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a % b == 0)
{
    Console.Write("Кратно");
}
else
{
    Console.Write($"Не кратно, остаток {a % b}");
}


