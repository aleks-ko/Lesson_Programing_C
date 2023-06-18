/* Задача 64: 
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

 int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine()!;
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите: ");
        value = Console.ReadLine()!;
    }
    Console.Clear();
    return val;
}

void NaturalNumber(int number)  //Вывод натуральных чисел от number до 1
{
    if (number>=1)
    {
        Console.Write($"{number} ");
        NaturalNumber(number-1);
    }
}

void NaturalEvenNumber(int number) //Вывод натуральных четных чисел от number до 1
{
    if (number>0)
    {
        if (number%2 == 0 )
        {
             Console.Write($"{number} ");
             number=number-2;
        }else number=number-1;
        NaturalEvenNumber(number);
    }
}
Console.Clear();
int number = Prompt("Введиче число: ");
Console.WriteLine();
NaturalNumber(number);
Console.WriteLine();
NaturalEvenNumber(number);