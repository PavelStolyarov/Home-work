// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


void FillArray(int[] array, int ArraySize, int start, int end)
{
    start = 100;
    end = 1000;
    for (int i = 0; i < ArraySize; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }

}

void PrintArray(int[] massive, int MassiveSize)
{
    for (int i = 0; i < MassiveSize; i++)
    {
        Console.Write($"{massive[i]} ");
    }
    Console.WriteLine();
}

void CountNumbers (int[] Massive, int length )
{
    int EvenCount = 0;
    int OddCount = 0;
    for (int i = 0; i < length; i++)
    {
        if(Massive[i] % 2 == 0) EvenCount++;
        else OddCount++;
    }
    Console.WriteLine($"Even: {EvenCount} Odd: {OddCount}");
}

Console.WriteLine("Enter size, and bounds");
int NumberOfElements = int.Parse(Console.ReadLine()!);
int MinValue = int.Parse(Console.ReadLine()!);
int MaxValue = int.Parse(Console.ReadLine()!);
int[] arr = new int[NumberOfElements];

FillArray(arr, NumberOfElements, MinValue, MaxValue);
PrintArray(arr, NumberOfElements);
CountNumbers(arr, NumberOfElements);