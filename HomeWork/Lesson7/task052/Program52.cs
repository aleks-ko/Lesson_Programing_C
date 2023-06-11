/* Задача 52. 
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] GetArray(int minValue, int maxValue)  //заполнения целочисленного массива
{
    int m = new Random().Next(minValue,maxValue);
    int n = new Random().Next(minValue,maxValue);
    int[,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j]=new Random().Next(minValue,maxValue) ;
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // вывод заданного массива по ровным столбцам для чисел от -10 до 10 не включая крайние значения
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

void PrintArray1 (double[] Array) // печать одномерного массива данных
{
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i].ToString("N1")+"  ");
    }
}

double [] SredAr (int[,] inArray) //расчет среднее арифметическое элементов в каждом столбце.
{
    double[] result = new double [inArray.GetLength(1)];
    double sredAr = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            sredAr = sredAr + inArray[j,i];
        }
        result [i] = Math.Round(sredAr/inArray.GetLength(0),2);
        sredAr = 0;
    }
    return result;
}

    int[,] Array = GetArray(1,10);
    Console.WriteLine();
    PrintArray(Array);
    Console.WriteLine();
    PrintArray1(SredAr( Array));