/* Задача 66: 
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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
    //Console.Clear();
    return val;
}

int NaturalNumber(int start ,int stop)
{
    if (start>stop)
    {
        return 0;
    }
    return start+NaturalNumber(start+1,stop);
}


int M = Prompt("Введиче число M : ");
int N = Prompt("Введиче число N : ");
if  (M>N)
{
    int temp = N;
    N = M;
    M = temp;
}
Console.WriteLine(NaturalNumber(M,N));
