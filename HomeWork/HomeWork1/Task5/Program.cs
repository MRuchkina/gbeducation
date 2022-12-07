Console.Clear();
Console.WriteLine("Введите число: ");
long n = Convert.ToInt64(Console.ReadLine());

if(n<100)
{
    Console.WriteLine("Нет"); 
}
else
{
    while (n>1000)
    {
        n=n/10; 
    }

    long m = n/10;
    long res = n-m*10;
    Console.WriteLine(res); 
}

