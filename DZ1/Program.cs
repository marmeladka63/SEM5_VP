//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

using System;

using System.Linq;
Console.Clear();
int[] array= new int[6].Select(x=>new Random().Next(0,1000)).ToArray();
Console.WriteLine(String.Join(" ", array));

Even(array);
void Even(int[] array)
{
   int count=0;
for(int i=0; i<6; i++)
{
    if(array[i]%2==0)
    count=count+1;
}
    
    Console.WriteLine(count);

}