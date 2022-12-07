// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

int num = new Random().Next(100,1000);
Console.WriteLine($"Сгенерировано число {num}");

num = num/10;
int res = num%10;

Console.WriteLine($"Вторая цифра числа: {res}");
