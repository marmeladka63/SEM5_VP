//Задайте массив. Напишите программу, которая определяет, присутсвует ли заданное число в массиве
// 4; массив [6,7,19,345,3] нет
// 3; массив [6,7,19,345,3] да

using System;

Console.Clear();
int[] array = GetArray(12, -9, 9);

Console.WriteLine(String.Join(" ",array));
Console.WriteLine("Введите число" );
int num=int.Parse(Console.ReadLine());
Console.WriteLine(FindNum(array,num)? "Да" : "Нет");

bool FindNum (int[] array, int num)
{
    foreach (int el in array)
    {
        if (el==num)
        {
            return true;

        }

    }
    return false;
}


/*int a =0;
while (a<12)
{
    if (array[a]==num)
    {
        Console.WriteLine("Есть");
    }
    else 
    {
        a=a+1;
    }
   
}
 Console.WriteLine("Нет");*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
