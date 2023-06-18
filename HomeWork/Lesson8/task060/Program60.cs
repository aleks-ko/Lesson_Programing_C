/* Задача 60. *** ...
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int[,,] GetArray(int x,int y, int z, int minValue, int maxValue)  //заполнения целочисленного трех мерного массива заданным рамером в заданном диаппазоне
{
    int[,,] result = new int [x,y,z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i,j,k]=new Random().Next(minValue,maxValue) ;
            }    
        }
    }
    return result;
}

void PrintArray(int[,,] inArray) // вывод заданного трех мерного массива по ровным столбцам 
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i,j,k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int [,,] UnikArray (int[,,] inArray,int minValue, int maxValue) // проверяет трехмерный массив если есть совпадения в элементах их перезаполняет рандомно и еще раз проверяет до тех пор пока не будут уникальные числа
{
    int [,,] result = new int [inArray.GetLength(0),inArray.GetLength(1),inArray.GetLength(2)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                result [i,j,k] =  inArray [i,j,k];
                int exit = 0;
                int count = 1;
                while (exit == 0)
                {
                    exit = 1;
                    count = 1;
                    for (int i1 = 0; i1 < inArray.GetLength(0); i1++)
                    {
                        for (int j1 = 0; j1 < inArray.GetLength(1); j1++)
                        {
                            for (int k1 = 0; k1 < inArray.GetLength(2); k1++)
                            {
                                if (result [i,j,k] ==  inArray [i1,j1,k1])
                                {
                                    if (count>1)
                                    {
                                    result[i,j,k]= new Random().Next(minValue,maxValue) ;
                                    exit =0;
                                    count = 1;
                                    }
                                    count++;
                                }
                                
                            }
                        }
                    }
                }
            }
        }
    }
    return result;
}

int [,,] Array = GetArray(2,2,2,10,100);
PrintArray(Array);
Console.WriteLine();
PrintArray(UnikArray(Array,10,100));