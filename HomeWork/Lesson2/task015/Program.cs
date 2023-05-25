//ввод числа, вывод является ли число выходным днем недели

void Weekend (int arg)
{
    if (arg > 0 & arg <8)
    {
        string[] weekend = {"этот день не выходной","этот день не выходной","этот день не выходной","этот день не выходной","этот день не выходной","этот день выходной!","этот день выходной!"};
        Console.WriteLine(weekend[arg-1]!);
    } else     Console.WriteLine("Неверный номер дня недели"!);
}

Console.WriteLine("Номер дня недели"!);
int num = int.Parse(Console.ReadLine());
Weekend(num);