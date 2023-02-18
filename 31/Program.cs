//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.
// GetArray(12, -9, 9)


Console.Clear();
int[] array = GetRandomArray (12,-9, 9);
Console.WriteLine($"[{String.Join(", ",  array)}]");



int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }

    return result;
}