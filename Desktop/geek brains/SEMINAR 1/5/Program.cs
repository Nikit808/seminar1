// Программа, которая при вводе N, все целые числа от -N до N 

Console.Clear();

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int N2 = -N;
while (N2 <= N)
{
    Console.WriteLine(N2);
    N2 = N2 + 1; 
}
