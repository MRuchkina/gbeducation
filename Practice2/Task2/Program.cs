// Получить случайное 3-значное число и удалить из него вторую цифру

int num = new Random().Next(100,1000);
Console.WriteLine($"Сгенерировано число {num}");

int a=num/100;
int b=num%10;

Console.WriteLine($"{a}{b}");
