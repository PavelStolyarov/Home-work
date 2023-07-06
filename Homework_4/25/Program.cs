// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int Power (int Base, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= Base;        
    }
    return power;
}

Console.Write("Enter base and positive exponent: ");
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);

int result = Power(A, B);
Console.WriteLine(result);


void negative_exponent (double Base, double Negative_exponent)
{
    double negative_power = 1;
    for (int i = 0; i > Negative_exponent; i--)
    {
        negative_power /= Base; 
    }
    Console.WriteLine(negative_power);
}

Console.Write("Enter Base and negative exponent: ");
double A2 = double.Parse(Console.ReadLine()!);
double B2 = double.Parse(Console.ReadLine()!);

negative_exponent(A2, B2);