//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

using System;

using System.Linq;

Console.Clear();
double[] array = GetArray(5, -9, 9);
Console.WriteLine(String.Join(" ", array));

/*Console.WriteLine(String.Join(" ", array));

double [] arr (double[] array)
{

double[] arr= new double[5];


Random rand = new Random();
for (int i = 0; i < 5; i++)
{
arr[i] =rand.Next(-100, 100)+ rand.NextDouble();
}
return array;
} */



double max = 0;
for (int j = 0; j <= 5; j++)
{
    if (array[j] > array[j + 1])
    {
        max = array[j];
    }
    else j++;
}

Console.WriteLine(max);


double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
