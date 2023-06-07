/* Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] ArrayInput ()//Заполняем массив введенными пользователем числе, выход любой символ (не число)
{
    int quit = 0; int index = 0;
    int[] ArrayNum = new int [1];
    while (quit==0)
    {
        Console.Write("Введите числа  (для выхода введите любой символ(не число))");
        string Input = Console.ReadLine();
        bool success = Int32.TryParse(Input, out int Num);
            if (success) 
            {            
                Array.Resize(ref ArrayNum, index+1);
                Console.WriteLine(Num);
                ArrayNum[index] = Num;
                index++;
            }
            else {
                quit=1;
            }
    }
    return ArrayNum;
}

int PozitivCountArray (int[] Array) //считаем кольво числе больше 0
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i]>0)
        {
            count++;
        }
    }
    Console.WriteLine($"Кол-во чисел больше 0 = {count}");
    return count;
}

PozitivCountArray(ArrayInput());