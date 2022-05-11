// Примеры задания массивов
using System;

using System.Linq;
// преобразование введенных с клавиатуры чисел в массив
//int[] array=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
// преобразование введеного массива умножение каждой цифры на -1
//int[] array1=array.Select(x=>x*-1).ToArray();
// задаем количество элементов в массиве и рандомно его заполняем цифрами от 0 до 100
int size = int.Parse(Console.ReadLine());
int[] array2= new int[size].Select(x=>new Random().Next(0,100)).ToArray();

//Console.WriteLine(String.Join(" ", array));

//Console.WriteLine(String.Join(" ", array1));

Console.WriteLine(String.Join(" ", array2));