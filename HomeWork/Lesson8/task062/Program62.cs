/* Задача 62 *** 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void PrintArray(int[,] inArray) // вывод заданного двух мерного массива по ровным столбцам от 0 до 99
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if ( inArray[i,j] < 10)
            {
                Console.Write($" {inArray[i,j]} ");
            }else if (inArray[i,j] < 100)
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] SpirArr (int size) // спиральное заполнение матрицы
{
    int [,] result = new int [size,size];
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = size;

    for (int i = 0; i < result.Length; i++) 
    {
        result[row, col] = i + 1;
        if (--visits == 0) 
        {
        visits = size * (dirChanges %2) + size * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return result;
}

Console.WriteLine("Введите размерность матрицы");
int size = int.Parse(Console.ReadLine()!);
PrintArray(SpirArr(size));