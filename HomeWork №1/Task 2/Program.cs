// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Enter numbers: ");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);
if(num1 >= num2 )
{
    if(num1 >= num3) Console.Write(num1);
    else Console.Write(num3);
}
else
{
    if(num2 >= num3) Console.Write(num2);
    else Console.Write(num3);
}