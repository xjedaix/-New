// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number < 99 || number > 1000)
{
        Console.WriteLine ("Введено не корректное число");
        return;
}
number = number / 10;
number = number % 10;
Console.WriteLine($"Вторая цифра трехзначного числа = {number}");


