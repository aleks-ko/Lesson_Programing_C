// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите три числа"!);
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());
if (number1 > number2){
    if (number1 > number3){
        Console.WriteLine("max = " + number1 );
        }
        else { 
        Console.WriteLine("max = " + number3 );
    }  
}    
    else {
    if (number2 > number3){
        Console.WriteLine("max = " + number2 );
        }
        else { 
        Console.WriteLine("max = " + number3 );
        }
    }