// Программа проверяет краность на 7 и 23

Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if (a%7==0 && a%23==0)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}