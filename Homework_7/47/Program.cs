// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArray(double[,] array, int RowNumber, int col, double start, double end)
{
    double  num = 0;
    for (int i = 0; i < RowNumber; i++)
    {
        for (int j = 0; j < col; j++)
        {
            num = start + new Random().NextDouble() * end;
            array[i,j] = Math.Round(num, 2);            
        }
    }

}

void PrintArray(double[,] massive, int RowNumber, int col)
{
    for (int i = 0; i < RowNumber; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{massive[i, j], 3}  ");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Enter size, and bounds");
int rows = int.Parse(Console.ReadLine()!);
int columns = int.Parse(Console.ReadLine()!);
double MinValue = double.Parse(Console.ReadLine()!);
double MaxValue = double.Parse(Console.ReadLine()!);
double[,] arr = new double[rows, columns];

FillArray(arr, rows, columns, MinValue, MaxValue);
PrintArray(arr, rows, columns);
