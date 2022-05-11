// задать массив от 0 до 1000 наполнить и посчитать суииу чисел в диапазоне от 0 до 99

using System;

Console.Clear();

//int[] array= new int[100].Select(x=>new Random().Next(0,1000)).ToArray();
int[] array= GetArray(123,0,1000);
int sum=0;
for (int i=0,i<123; i++ )
{
if (array[i]>=10&&array[i]<=99 )
{
    sum++;
}
}


 Console.WriteLine($"Сумма=  ,{sum}");