// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();

Console.Write("Введите X координаты точки A: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y координаты точки A: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z координаты точки A: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите X координаты точки B: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y координаты точки B: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z координаты точки B: ");
int z2 = int.Parse(Console.ReadLine()!);

double Dlina(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
    return result;

}
Console.Write($"Длина отрезка равна: {Dlina(x1,y1,z1,x2,y2,z2):f2}");