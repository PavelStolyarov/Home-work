// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


void FindIntersection(int b1, int k1, int b2, int k2)
{
    if(b1 == b2 && k1 == k2)
    {
        Console.WriteLine("graphs are identical");
    } 
    else
    {
        int first = b2 - b1;
        int sec = k1 - k2;
        double x = Math.Round((first) / (sec * 1.0), 2);
        double y = k1 * x + b1;
        Console.WriteLine($"Coordinates of the intersection point of two graphs: ({x}, {y})");
    }
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);
int num4 = int.Parse(Console.ReadLine()!);
FindIntersection(num1, num2, num3, num4);