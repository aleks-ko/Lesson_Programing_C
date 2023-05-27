/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int Intcheck (string message) 
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

    
void CalcDist3D (int Ax, int Ay, int Az, int Bx, int By, int Bz) 
{
    double dist = Math.Sqrt(Math.Pow((Ax-Bx),2)+Math.Pow((Ay-By),2)+Math.Pow((Az-Bz),2));
    Console.WriteLine("Расстояние между точками: "+dist);
}

int Ax = Intcheck ("Введите координату X точки A: ");
int Ay = Intcheck ("Введите координату Y точки A: ");
int Az = Intcheck ("Введите координату Z точки A: ");

int Bx = Intcheck ("Введите координату X точки B: ");
int By = Intcheck ("Введите координату Y точки B: ");
int Bz = Intcheck ("Введите координату Z точки B: ");

CalcDist3D(Ax,Ay,Az,Bx,By,Bz);
