//28 Напишите программу, которая принимает на вход число N
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5


Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма от 1 до {n} равна  {GetSum(n)}");
int GetSum (int limit) // переменная "limit" используется в качестве параметра функции "GetSum", чтобы указать границу для суммирования целых чисел от 1 до "limit".
{

    int sum = 1;
    for (int i = 1; i <= limit; i++) // пока i = 1; i <=limit; i + 1
    {
     sum *= i; // i*1 -> GetSum
    }
    return sum;
}