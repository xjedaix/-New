// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру дня недели недели: ");
int DayOfWeek = int.Parse(Console.ReadLine());
if (DayOfWeek < 1 || DayOfWeek > 7)
{
        Console.WriteLine ("Введен не верный день недели");
        return;
}
if (DayOfWeek == 6 || DayOfWeek == 7)
{
        Console.WriteLine ("Выходной день");
}

if (DayOfWeek == 1)
{
    Console.WriteLine("Понедельник");
}
if (DayOfWeek == 2)
{
    Console.WriteLine("Вторник");
}
if (DayOfWeek == 3)
{
    Console.WriteLine("Среда");
}
if (DayOfWeek == 4)
{
    Console.WriteLine("Четверг");
}
if (DayOfWeek == 5)
{
    Console.WriteLine("Пятница");
}
if (DayOfWeek == 6)
{
    Console.WriteLine("Суббота");
}
if (DayOfWeek == 7)
{
    Console.WriteLine("Воскресенье");
}