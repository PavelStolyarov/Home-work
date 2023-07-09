// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] array, int ArraySize, int start, int end)
{
    start = 1;
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

void OddSum (int[] Massive, int length )
{
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if(i % 2 != 0) sum += Massive[i];
    }
    Console.WriteLine($"{sum}");
}

Console.WriteLine("Enter size, and bounds");
int NumberOfElements = int.Parse(Console.ReadLine()!);
int MinValue = int.Parse(Console.ReadLine()!);
int MaxValue = int.Parse(Console.ReadLine()!);
int[] arr = new int[NumberOfElements];

FillArray(arr, NumberOfElements, MinValue, MaxValue);
PrintArray(arr, NumberOfElements);
OddSum(arr, NumberOfElements);