﻿// Напишите программу, которая выводит на экран числа от 1 до 100. При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz. Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz. Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.
Console.Clear();

for (int i=1; i<=100; i++)
{
    if(i%15==0) Console.Write("FizzBuzz ");
    else
    {
        if(i%5==0) Console.Write("Buzz ");
        else
        {
           if(i%3==0) Console.Write("Fizz ");   
           else Console.Write($"{i}. "); 
        }
    }
}