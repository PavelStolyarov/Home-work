// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

 
int Nums(int number, int num)
{
    if (num - 1 == number)
    {
        return 0;
    }
    return Nums(number - 1, num) + number;
}
int M = int.Parse(Console.ReadLine()!);
int N = int.Parse(Console.ReadLine()!);
Console.Write(Nums(N, M));