// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
            res[i] = new Random().Next(100, 1000);
    }
return res;
}

int GetCount(int[] numArray)
    {
        int count = 0;
    for (int i = 0; i < numArray.Length; i++)
        {
            if (numArray[i] %2==0)
            {
                count++;
            }
        }
    return count;
    }
Console.Clear();

int[] array = GetArray(4, 100, 1000);
Console.WriteLine(String.Join(",", array));
Console.Write($"Количество четных чисел: {GetCount(array)}");
