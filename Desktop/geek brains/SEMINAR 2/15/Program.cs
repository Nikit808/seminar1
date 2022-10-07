// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите число дня недели: ");
int x = int.Parse(Console.ReadLine()!);

if (x ==1||x==2||x==3||x==4||x==5)
{
    Console.WriteLine("Выходной - нет");
}
else if (x == 6||x==7)
{
    Console.WriteLine("Выходной - Да");
}
else
{
    Console.WriteLine("Введите число дня недели снова: ");
}