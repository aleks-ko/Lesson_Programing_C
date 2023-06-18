/* Задача 56: 
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

// void PrintArray1 (int[] Array) // печать одномерного массива данных (для проверки работы)
// {
//     Console.WriteLine("сумма построчная в массиве");
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Console.Write(Array[i].ToString("N1")+"  ");
//     }
// }

int [] SumStringArray (int[,] inArray) //создает массив с построчной суммой элементов
{
    int [] result = new int [inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[i] = result[i]+inArray[i,j];
        }
    }
    return result;
}

void minValue (int [] inArray) //выводит номер строки с наименьшим значением (счет номера строки для пользователя)
{
    int minValue = inArray[0];
    int indexMin = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (minValue>inArray[i])
        {
            minValue = inArray[i];
            indexMin = i;
        }
    }
    Console.WriteLine($"Минимальная сумма = {minValue} - это строка {indexMin+1}");
    //Console.Write(indexMin+1);
}

int [,] Array = GetArray(5,6,1,10);
PrintArray (Array);
Console.WriteLine();
//PrintArray1(SumStringArray(Array)); // для проверки работы
//Console.WriteLine(); // для проверки работы
minValue(SumStringArray(Array));