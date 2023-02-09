// Задача номер 7. Напишите программу, которая принимает на вход 
// трехзначное число и на выходе показывает последнюю цифру этого числа 456

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number1 = int.Parse(Console.ReadLine());

if (number1 < 100 || number1 > 999 )
{
    Console.WriteLine("число введено не верно");
    return;
}
int otvet = number1 % 10;
Console.WriteLine($"{otvet}");
