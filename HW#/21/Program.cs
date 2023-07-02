// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

Console.WriteLine("Enter numbers: ");

double num1 = double.Parse(Console.ReadLine()!);
double num2 = double.Parse(Console.ReadLine()!);
double num3 = double.Parse(Console.ReadLine()!);
double num4 = double.Parse(Console.ReadLine()!);
double num5 = double.Parse(Console.ReadLine()!);
double num6 = double.Parse(Console.ReadLine()!);

double result = Distance(num1, num2, num3, num4, num5, num6);
Console.WriteLine(result);