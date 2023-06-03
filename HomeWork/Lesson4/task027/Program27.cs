/* Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumNum (int arg)
{
    int count=0;
    while (arg>0)
    {
        count=count+arg%10;
        arg = arg/10;
    }
    return (count);
}

void SumNumWrite (int arg) 
{
    Console.WriteLine($"Сумма цифр в числе = {arg} = {SumNum(arg)}");
}

Console.WriteLine("Введите число");
SumNumWrite(int.Parse(Console.ReadLine()!));