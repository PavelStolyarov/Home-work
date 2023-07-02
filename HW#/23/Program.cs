// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void power (int N)
{
    int help = 1;
    if(N > 1)
    {
        while(help <= N)
        {
            Console.Write($"{Math.Pow(help, 3)} ");
            help++;
        }
    }
    else
    {
        while(help >= N)
        {
            Console.Write($"{Math.Pow(help, 3)} ");
            help--;
        }
    }
}


int num = int.Parse(Console.ReadLine()!);
power(num);
