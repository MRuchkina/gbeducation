Console.Clear();
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int min;
int max;

if (a>b)
{
  min = b;
  max = a;
}
else
{
  min = a;
  max = b;
}

Console.Write("min: ");
Console.WriteLine(min);


Console.Write("max: ");
Console.WriteLine(max);