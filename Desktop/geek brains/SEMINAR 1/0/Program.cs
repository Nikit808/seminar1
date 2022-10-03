// программа которая считает квадрат от числа

Console.Clear ();
Console.Write (" введите число: ");

int number = int.Parse (Console.ReadLine()!);

int sqr = number*number; 
Console.WriteLine($"квадрат числа {number} равен {sqr}");
