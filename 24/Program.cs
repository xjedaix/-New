﻿// напишите программу, которая принимает на вход число A
// и выдает сумму чисел от 1 до A
// a = 5
// sum = 5
// sum = 1 + 2 + 3 + 4 + 5

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма от 1 до {n} равна  {GetSum(n)}");

int GetSum (int limit)
{

    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
     sum += i;
    }
    return sum;
}