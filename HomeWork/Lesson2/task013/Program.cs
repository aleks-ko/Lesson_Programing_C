//ввод числа, проверка его на кол-во знаков и вывод 3-го числа
int ToThreedigit (int arg)
{
    int i = arg;
    while (i > 999)
    {
        i = i/10;
    }
    return (i);
}

void  ThreeDigit (int arg)
{
    if (arg > 99)
    {
        Console.WriteLine("Третья цифра = " + ToThreedigit(arg)%10!);
    }else
    {
    Console.WriteLine("Третьей цифры нет "!);
    }
} 

Console.WriteLine("Введите число"!);
int number = int.Parse(Console.ReadLine());
ThreeDigit(number);