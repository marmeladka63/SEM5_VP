//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

using System.Linq;
//Console.Clear();
double[] array= new double[5];


Random rand = new Random();
for (int i = 0; i < 5; i++)
{
array[i] =rand.Next(-100, 100)+ rand.NextDouble();
}

Console.WriteLine(String.Join(" ", array));

double max=0;
for (int i = 0; i < 5; i++)
{


if (array[i]>array[i+1])
{
    max=array[i];
}
else i++;
}
Console.WriteLine(max);
