// Ввестти трехзначное число и на выходе показать вторую цифру

Console.Clear();

Console.WriteLine("Введите трехзначно число: ");
int num = int.Parse(Console.ReadLine()!);

int a2=num/10%10;

Console.Write ($"Число {num} - {a2}");



