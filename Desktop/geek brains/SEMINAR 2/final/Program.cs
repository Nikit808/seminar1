// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
string[] arrayIN = new string[] { "1234", "1567", "-2", "computer science" };
string[] arrayOUT = new string[arrayIN.Length];
void ArrayINandOUT(string[] arrayIN, string[] arrayOUT)
{
    int count = 0;
    for (int i = 0; i < arrayIN.Length; i++)
    {
        if (arrayIN[i].Length <= 3)
        {
            arrayOUT[count] = arrayIN[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayINandOUT(arrayIN, arrayOUT);
PrintArray(arrayOUT);