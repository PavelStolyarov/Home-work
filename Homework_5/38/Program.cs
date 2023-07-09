// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


void FillArray(double[] array, int ArraySize, double start, double end)
{
  ArraySize = array.Length;
    for (int i = 0; i < ArraySize; i++)
    {
      array[i] = new Random().NextDouble() * 100;
    }

}

void PrintArray(double[] massive, int MassiveSize)
{
    MassiveSize = massive.Length;
    for (int i = 0; i < MassiveSize; i++)
    {
      Console.Write($"{massive[i]} ");
    }
    Console.WriteLine();
}

void MinAndMax (double[] Massive, int length )
{
    length = Massive.Length;
    double Min = Massive[0];
    double Max = Massive[0];
    for (int i = 0; i < length; i++)
    {
        if(Max < Massive[i]) Max = Massive[i];
        if(Min > Massive[i]) Min = Massive[i];
    }
    Console.WriteLine($"Max: {Max}, Min: {Min}");
    Console.WriteLine($"{Max - Min}");
}

Console.WriteLine("Enter size, and bounds");
int NumberOfElements = int.Parse(Console.ReadLine()!);
double MinValue = double.Parse(Console.ReadLine()!);
double MaxValue = double.Parse(Console.ReadLine()!);
double[] arr = new double[NumberOfElements];

FillArray(arr, NumberOfElements, MinValue, MaxValue);
PrintArray(arr, NumberOfElements);
MinAndMax(arr, NumberOfElements);