try
{
    Console.WriteLine("Введите координату X:");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координату Y:");
    int y = Convert.ToInt32(Console.ReadLine());
}
catch
{
    
}



void CheckKoord(int x, int y)
{
    if (x>0 && y>0) Console.WriteLine("Это четверть №1");
    else if (x>0 && y<0) Console.WriteLine("Это четверть №4");
    else if (x<0 && y>0) Console.WriteLine("Это четверть №2");
    else if (x<0 && y>0) Console.WriteLine("Это четверть №3");
    else Console.WriteLine("Точка находится на оси");
}