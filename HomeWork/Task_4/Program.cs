﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число: N = ");
int writeNum = int.Parse(Console.ReadLine());
int begingNum = 1;

while (begingNum <= writeNum) 
{
    if ((begingNum % 2) == 0)
    {
        Console.Write($"{begingNum} ");
    }
    begingNum += 1;
}


