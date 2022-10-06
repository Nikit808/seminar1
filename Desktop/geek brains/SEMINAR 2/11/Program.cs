// Программма выводит случайное трех значное число и убирает вторую цифру

Console.Clear ();
int num = new Random().Next (100, 1000);

int a1 = num/100;
int a3 = num%10;

Console.Write ($"Число {num} - {a1}{a3}");



