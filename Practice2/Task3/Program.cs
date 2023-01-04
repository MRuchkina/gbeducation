// Написать программу, которая будет принимать на вход 2 числа и выводить, является ли второе число кратным первому - вывести либо остаток от деления, либо слово "Кратно"
Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int c = a%b;
if (c==0) Console.WriteLine("Кратно");
else Console.WriteLine($"Остаток: {c}");