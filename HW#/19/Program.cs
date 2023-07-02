// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void check(int number)
{
    int ones = number % 10;
    int SecondDigit = (number % 100) / 10;
    int FourthDigit = (number % 10000) / 1000;
    int FifthDigit = number / 10000;
    if(ones == FifthDigit && SecondDigit == FourthDigit)
    {
        Console.WriteLine("that number is palindrom");
    }
    else
    {
        Console.WriteLine("That number is not palindrom");
    }
}

int num = new Random().Next(10000, 100000);
// num = 12321;
Console.Write($"{num} ");
check(num);