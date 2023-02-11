// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int result = number1 % number2;
Console.WriteLine($"{result}");
if (result == 0)
{
    Console.WriteLine($"Число кратно = {result}");
    return;
}
else
{
    Console.WriteLine($"Число не кратно, остаток = {result}");
    return;
}

