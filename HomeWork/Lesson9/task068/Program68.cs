/* Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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
    return val;
}

int AkkermanFunc(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    if(m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

int M = Prompt("Введиче число M : ");
int N = Prompt("Введиче число N : ");
if  (M>= 0 && N>=0)
{
    Console.WriteLine(AkkermanFunc(M,N));
} else 
Console.WriteLine("Введены не верные значения M и N должны быть не отрицательные.");

