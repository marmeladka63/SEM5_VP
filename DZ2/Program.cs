// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

using System.Linq;
Console.Clear();
int[] array= new int[4].Select(x=>new Random().Next(-100,100)).ToArray();
Console.WriteLine(String.Join(" ", array));

Odd(array);
void Odd(int[] array)
{
   int sum=0;
for(int i=0; i<4; i++)
{
    if(i%2==1)
    sum=sum+array[i];
}
    
    Console.WriteLine(sum);
}
