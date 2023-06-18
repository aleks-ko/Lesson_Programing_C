/* Задача 54: 
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] GetArray(int Long,int height, int minValue, int maxValue)  //заполнения целочисленного двух мерного массива заданным рамером в заданном диаппазоне
{
    int[,] result = new int [Long,height];
    for (int i = 0; i < Long; i++)
    {
        for (int j = 0; j < height; j++)
        {
            result[i,j]=new Random().Next(minValue,maxValue) ;
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // вывод заданного двух мерного массива по ровным столбцам для чисел от -10 до 10 не включая крайние значения
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] SortArray (int[,] inArray) //упорядочит по убыванию целочисленные элементы каждой строки двумерного массива.
{
    int maxlong = 0;
    int temp = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        maxlong = inArray.GetLength(1);
        int exit = 0;
        while (exit == 0)
        {
            exit = 1;
            for (int j = 0; j < maxlong; j++)
            {
                if (j+1 < maxlong )
                {
                    if (inArray[i,j+1]>inArray[i,j])
                    {
                        temp = inArray[i,j];
                        inArray[i,j] = inArray[i,j+1];
                        inArray[i,j+1] = temp;
                        exit = 0;
                    } 
                }
            }
        }
    }
    return inArray;
}

int [,] Array = GetArray(5,6,1,10);
PrintArray (Array);
Console.WriteLine();
PrintArray (SortArray (Array));