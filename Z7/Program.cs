// Пример как искать числа в массивах
using System;

using System.Linq;
//Console.Clear();
int[] array= new int[20].Select(x=>new Random().Next(0,1000)).ToArray();
Console.WriteLine(String.Join(" ", array));
int[] k= array.Where(x=>x>=9&&x<=100).ToArray();
Console.WriteLine(String.Join(" ", k));