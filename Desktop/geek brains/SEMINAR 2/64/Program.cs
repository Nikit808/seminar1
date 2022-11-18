// 64

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
Numbers(number, count);


void Numbers(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        Numbers(n, count + 1);
        Console.Write(count + " ");
    }
}
