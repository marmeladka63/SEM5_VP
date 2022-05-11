// задать массив от 0 до 1000 наполнить и посчитать суииу чисел в диапазоне от 0 до 99

using System;

Console.Clear();

//int[] array= new int[100].Select(x=>new Random().Next(0,1000)).ToArray();
int[] array= GetArray(12,0,1000);

Console.WriteLine(String.Join(" ", array));


int sum=0;

for (int j=0; j<12; j++ )
{
if (array[j]>=10&&array[j]<=99 )
{
    sum++;
}
}


 Console.WriteLine($"Сумма=  {sum}");

 int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}