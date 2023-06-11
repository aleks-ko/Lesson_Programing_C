/* Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int Prompt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] GetArray(int rows,int colums,int minValue,int maxValue)  //заполнения вещественными числами массив с десятичной частью(как в примерах)
{
    double[,] result = new double [m,n];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i,j]=Math.Round(new Random().NextDouble()*new Random().Next(minValue,maxValue),1) ;
        }
    }
    return result;
}

void PrintArray(double[,] inArray) // вывод заданного массива по ровным столбцам для чисел от -10 до 10 не включая крайние значения
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i,j]<0)
            {
                Console.Write($"{inArray[i,j].ToString("N1")} ");
            } else Console.Write($" {inArray[i,j].ToString("N1")} ");
        }
        Console.WriteLine();
    }
}


int rows = Prompt("Введите количество строк массива: ");
int colums = Prompt("Введите количество столбцов массива: ");
PrintArray(GetArray(rows,colums,-9,10));