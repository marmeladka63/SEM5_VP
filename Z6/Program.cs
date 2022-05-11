// Массив создать и найти произведение  первое и последнего числа, второго и предпоследнего... и т.д
using System;

Console.Clear();

int[] array = new int[9].Select(x=>new Random().Next(0,10)).ToArray();
Console.WriteLine(String.Join(" ", array));

Multi(array);
void Multi(int[] array)
{
   int mult=1;
for(int i=0; i<array.Length/2; i++)
{
    mult=array[i]*array[array.Length-i-1];
    
    Console.WriteLine(mult);

}
if(array.Length%2==1) Console.WriteLine(array[array.Length/2]);
}

