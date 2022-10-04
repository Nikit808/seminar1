// Задача 6. Найти четное 

Console.Clear();

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);

if (a%2==0)
Console.WriteLine($"Число {a} - Четное"); 
else
Console.WriteLine($"Число {a} - Нечетное");

