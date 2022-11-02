// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
            res[i] = new Random().Next(-100, 100);
    }
return res;
}

int Summa(int[] numArray)
{
    int sum = 0;
    for (int i = 1; i < numArray.Length; i=i+2)
        {
            sum += numArray[i];
        }  
    return sum;       
}
Console.Clear();

int[] array = GetArray(5, -100, 100);
Console.WriteLine(String.Join(",", array));
Console.WriteLine($"Сумма элементов на нечетной позиции: {Summa(array)}");

