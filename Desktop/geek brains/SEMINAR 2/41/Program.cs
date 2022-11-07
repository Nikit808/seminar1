// 41

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
    res[i] = int.Parse(nums[i]);
    }
    return res;
}
int Count(int[] numArray)
    {
        int count = 0;
    for (int i = 0; i < numArray.Length; i++)
        {
            if (numArray[i]>0)
            {
                count++;
            }
        }
    return count;
    }
Console.Clear();

Console.WriteLine("Введите числа "); 
String input=Console.ReadLine()!;
int [] numArray=GetArrayFromString(input);
int count=Count(numArray); 
Console.WriteLine($"Кол-во положительных чисел: {count}");
