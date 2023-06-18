/* Задача 58: 
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int [,] Multiplication (int [,] inArray1,int [,] inArray2) // Умножение матриц любого размера
{
    int [,] result = new int[inArray1.GetLength(0),inArray2.GetLength(1)];
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray1.GetLength(1); j++)
        {
            for (int  k = 0; k < inArray2.GetLength(1); k++)
            {
                //Console.Write($"== {result [i,j]} + {inArray1[i,k]} * {inArray2[k,j]} ==");//для проверки
                result [i,j] = result [i,j] + inArray1[i,k]*inArray2[k,j];
                //Console.Write($" итог == {result[i,j]} =="); //для проверки
            }
            //Console.Write($"{result[i,j]} "); //для проверки
        }
        //Console.WriteLine(); //для проверки
    }
    return result;
}

int [,] Array1 = GetArray(2,2,1,10);
int [,] Array2 = GetArray(2,2,1,10);
Console.WriteLine("Array1");
PrintArray(Array1);
Console.WriteLine();
Console.WriteLine("Array2");
PrintArray(Array2);
Console.WriteLine();
Console.WriteLine("Матрица умножения Array1 * Array2 ");
int [,] result = Multiplication(Array1,Array2);
PrintArray(result);