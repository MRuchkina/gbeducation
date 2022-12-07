Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int b = a/2;
int c = b*2;

Console.Write("Четное: ");

if(c==a)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}