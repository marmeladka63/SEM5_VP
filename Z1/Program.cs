// Создать массив 12 элементов, заполненых в случайном порядке от -9 до +9 и посчитать отдельно отрицательные, отдельно положительные.

using System;

Console.Clear();

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

int pozitivSum = 0;
int negativSum = 0;

// чтение элементов массива
foreach (int el in array)
{
    pozitivSum += el > 0 ? el : 0;
    negativSum += el < 0 ? el : 0;
}
Console.WriteLine($"Pozitiv Sum= {pozitivSum}, Negativ Sum = {negativSum}");

// Метод получения массива

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}