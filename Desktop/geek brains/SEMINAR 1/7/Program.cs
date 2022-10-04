// Принимает трехначное число и показывает последнюю цифру

Console.Clear();

Console.WriteLine("Введите трехзначное число: "); 
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{N%10}");

