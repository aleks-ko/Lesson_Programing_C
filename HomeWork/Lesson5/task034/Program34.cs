/* Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] GetArray ()
{
    int[] Array = new int [new Random().Next(2,10)];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i]= new Random().Next(100,1000) ;
    }
     return (Array);
 }

int CountArray (int[] Array)
{
    int CountArray=0;
    foreach (var item in Array)
    {
        if (item%2 == 0)
        {
            CountArray++;
        }
    }  
     return (CountArray);
 }


void PrintArray (int[] Array) 
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]+", ");
    }
}

int[] Array = GetArray();
PrintArray(Array);
Console.Write($" Кол-во четных чисел в массиве = {CountArray(Array)}");