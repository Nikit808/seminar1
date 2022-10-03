// Программа, которая при вводе N, все целые числа от -N до N 

Console.Clear();

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int N2 = N*-1;
int index = N2;
Console.WriteLine(N2);
while(  index < N)
{
    N2= N2 + 1;
    Console.WriteLine(N2);
    index = index + 1;
}
