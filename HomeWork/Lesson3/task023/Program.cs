/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int Prompt(String message)
{
Console.Write(message);
return int.Parse(Console.ReadLine()!); ;
}

void PrintDegreTable(int number, int Degre)
{
    int i = 1;
    while (i <= number)
    {
        Console.Write(Math.Pow(i, Degre) + " ");
        i++;
    }
}

int Number = Prompt("Введите число(кол-во проходов): ");
int Degre = Prompt("Введите в какую степень желате возвести: ");
PrintDegreTable(Number,Degre);