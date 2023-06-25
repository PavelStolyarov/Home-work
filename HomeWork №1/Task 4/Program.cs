// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Enter N: ");
int N = int.Parse(Console.ReadLine()!);
while(N != 1)
{
    if(N > 1)
    {
        if(N % 2 == 0)
        {
            Console.Write(N + " ");
            N--;
        }
        else
        {
            N--;
        }
    }
    else
    {
        if(N % 2 == 0)
        {
            Console.Write(N + " ");
            N++;
        }
        else
        {
            N++;
        }
    }
}