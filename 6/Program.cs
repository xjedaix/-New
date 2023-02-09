// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int i = number % 2;

if (i == 0)
{
    Console.WriteLine($"{i} - число четное");
}
else
    Console.WriteLine($"{i} - число не четное");