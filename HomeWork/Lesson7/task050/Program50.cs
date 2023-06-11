/* Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет [1,7]-это позиция элемента 1 - строка, 7 - столбец
*/

int Prompt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

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

void PrintArrayElement(int rows,int colums,int[,] inArray) // вывод заданного элемента массива подсчет строк как для пользователя
{
    int RowsinArray = inArray.GetLength(0);
    int ColumsinArray = inArray.GetLength(1);
    bool ExistenceElement = false;
    rows = rows-1;
    colums = colums-1;
    if (rows <= RowsinArray)
    {
        if (colums <= ColumsinArray)
        {
            ExistenceElement = true;
        }
    }

    if (ExistenceElement == true)
    {
        Console.WriteLine($"Заданый элемент в строке {rows+1} и столбце {colums+1} равен = {inArray[rows,colums]}");
    } else Console.WriteLine($"Заданый элемент в строке {rows+1} и столбце {colums+1}  - не существует");
} 


int rows = Prompt("Введите позицию элемента по строке массива: ");
int colums = Prompt("Введите позицию элемента по столбцу массива: ");
if (rows > 0 && colums >0)
{
    int[,] Array = GetArray(1,10);
    Console.WriteLine();
    PrintArray(Array);
    Console.WriteLine();
    PrintArrayElement(rows,colums,Array);
} else Console.WriteLine($"Заданый элемент в строке {rows} и столбце {colums}  - не существует");
