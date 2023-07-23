// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.
 
void Nums(int number, int num)
{
    if (num - 1 == number)
    {
        return;
    }
    if(number % 2 == 0) 
    {
        Nums(number - 1, num);
        Console.Write(number + " ");
    }
    else 
    {
        Nums(number - 1, num);
    }
}
int M = int.Parse(Console.ReadLine()!);
int N = int.Parse(Console.ReadLine()!);
Nums(N, M);