// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


void Numberssss()
{
    int count = 0;
    Console.WriteLine("Enter numbers: ");
    while (true)
    {
        
        int number = int.Parse(Console.ReadLine()!);
        if(number > 0) count++;
        else break;
    }
    Console.WriteLine($"number of numbers greater than zero: {count}");
}
Numberssss();