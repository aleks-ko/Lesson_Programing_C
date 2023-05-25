// // на вход трехзначное число, на выходе вторая цифра

void secondNumber (int SecNum)
{
    if (SecNum>99 & SecNum <1000)
    {
        int Secondnum = SecNum/10%10;
        Console.WriteLine("Вторая цифра = " + Secondnum);
    }else Console.WriteLine("Число не трехзначное");
}

Console.WriteLine("Введите трехзначное число"!);
int number = int.Parse(Console.ReadLine());
secondNumber(number);
