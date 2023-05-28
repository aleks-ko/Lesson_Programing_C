/* Задача 19
 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 14212 -> нет
 12821 -> да
 23432 -> да
*/
int Rownumber (int arg)  // - разрядность числа
{
    int count=1; 
    while (arg > 9)
    {
        arg=arg/10;
        count++;
    }   
    return (count);
}

int CenterRownumber (int arg) //Центр рядности числа или округление в большую сторону;
{
    int result;
    if (arg%2>0)
    {
        result = arg/2 + 1;
    }else result = arg/2;
    return (result);
}

void Palindrome (int arg)  //проверяет является ли число палиндромом или нет и выдает результат
{
    int i = 1; // счетчик цикла
    int count=Rownumber(arg); // count - разрядность числа
    int Polcentr = CenterRownumber(count); //Центр рядности числа
    int Polindrom = 0; // Переменная анализа является ли число полиндромом 
    int i1 = Polcentr; // Точка рядного множителя числа 1 
    int i2 = Polcentr-2; // Точка рядного множителя числа 2
    int num1,num2; // числа 1 и 2 учавствующие в сравнении

    if (count == 1)
    {
        Polindrom=1;
    }else if (count%2>0)
    {
        while (i <= (count/2))
        {
            num1=arg/(int)Math.Pow(10,i1)%10;
            num2=arg/(int)Math.Pow(10,i2)%10;
            if (num1 != num2)
            {
                Polindrom=0;
                break;
            }else
            {
                i1++;
                i2--;
                i++;
            }
            Polindrom=1;
        }
    } else
    {
        //i = 1;
        //int i1 = Polcentr;
        //int i2 = Polcentr-1;
        i2++;
        while (i <= (count/2))
        {
            num1=arg/(int)Math.Pow(10,i1)%10;
            num2=arg/(int)Math.Pow(10,i2)%10;
            if (num1 != num2)
            {
                Polindrom=0;
                break;
            }else
            {   
                i1++;
                i2--;
                i++;
            }
            Polindrom=1;
        }
    }
    if (Polindrom == 1)
    {
        Console.WriteLine($"Введеное число {arg} полиндром !");
    }else
    {
        Console.WriteLine($"Введеное число {arg} не является полиндромом");
    }
}

Console.WriteLine("Введите число палиндром"!);
int number = int.Parse(Console.ReadLine()!);
Palindrome(number);