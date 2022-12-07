Console.Clear();
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

int min=0;
int max=0;

if (a>=b && a>=c)
{
  max = a;
}
else
{
    if (b >= a && b >= c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
}

if (a<=b && a<=c)
{
  min = a;
}
else
{
    if (b <= a && b <= c)
    {
        min = b;
    }
    else
    {
        min = c;
    }
}



Console.Write("max: ");
Console.WriteLine(max);

Console.Write("min: ");
Console.WriteLine(min);
