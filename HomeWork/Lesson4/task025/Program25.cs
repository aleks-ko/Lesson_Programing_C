/* Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int RaiseToPower (int argA,int argB)
{
    int count = 0;
    if (argB >= 0)
    {
        count = argA;
    //Num = (int)Math.Pow(argA,argB); - в задаче решить спомощью цикла так что ниже решение по задаче
        for (int i = 1; i < argB ; i++)
        {   
            count = count * argA;
        }
    }else Console.WriteLine("введена не корректная степень");
    return (count);
}

void RaiseToPowerWrite (int argA,int argB) 
{
    int count = RaiseToPower(argA,argB);
    Console.WriteLine($" число А = {argA} в степени В = {argB} будет = {count} ");
}

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B (Возведение числа А в натуральную степень)");
int B = int.Parse(Console.ReadLine()!);
RaiseToPowerWrite(A,B);