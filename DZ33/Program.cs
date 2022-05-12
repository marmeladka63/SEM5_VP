//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

using System;

using System.Linq;

Console.Clear();
double[] array = GetArray(5, -9, 9);
Console.WriteLine(String.Join(" ", array));


double min = array[0];
for (int j = 0; j < 5; j++)
{
    if (min > array[j])
    {
        min = array[j];

    }
}


double max = array[0];
for (int j = 0; j < 5; j++)
{
    if (max < array[j])
    {
        max = array[j];

    }
}
Console.WriteLine($"sum = {max + min}");



double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

