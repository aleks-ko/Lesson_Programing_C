/* Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double[] XLine ( double b1,double k1,double b2,double k2) //вычисления пересечения прямых
{
    double x=(b2-b1)/(k1-k2);
    double y=k1*x+b1;
    double[] result = {x,y};
    return (result);
 }


void PrintKoordinates (double[] Array) //печать точек пересечения прямых
{
    Console.WriteLine("координаты точки пересечения двух прямых");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]+", ");
    }
}


Console.WriteLine("Введите переменную b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
PrintArray(XLine(b1,k1,b2,k2));