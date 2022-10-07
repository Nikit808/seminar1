// / Напишите программу, которая будет выдавать назвние дня недели

Console.Clear();
Console.WriteLine("Введите число дня недели: ");
int x = int.Parse(Console.ReadLine()!);

if (x ==1||x==2||x==3||x==4||x==5)
{
    Console.WriteLine("нет");
}
else if (x == 6||x==7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Введите число дня недели снова: ");
}