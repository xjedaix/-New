// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if(number < 100)
{
    Console.WriteLine("Третья цифра в числе отсутствует");
    return;
}

int number1 = number % 10;
int number2 = number1[3];
Console.WriteLine($"третья цифра числа - {number2}");