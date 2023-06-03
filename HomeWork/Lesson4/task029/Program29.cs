/* Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] ArrayElementsRnd (int arg)
{
    int[] Array = new int [arg];
    for (int i = 0; i < arg; i++)
    {
        Array[i]= new Random().Next(0,100) ;
    }
     return (Array);
 }

 void ArrayElementsRndWrite (int arg) 
{
    int[] Array = ArrayElementsRnd(arg);
    for (int i = 0; i < arg; i++)
    {
        Console.Write(Array[i]+", ");
    }
}

Console.WriteLine("Введите размер массива");
ArrayElementsRndWrite(int.Parse(Console.ReadLine()!));