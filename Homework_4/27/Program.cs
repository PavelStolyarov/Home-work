// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int num)
{
    int result = 0;
    for (int i = 10; i <= Math.Abs(num * 10); i *= 10)
    {
        result += (num % i) / (i / 10);
    }
    return result;
}

int number = new Random().Next(-100000, 100001);
Console.WriteLine(number);
int sum_of_digits = Sum(number);
Console.WriteLine(sum_of_digits);