//30 Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]

// a = new Random().Next()

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int[] array = GetBinArray(num);
Console.Write($"[{String.Join(", ", array)}]");

int []