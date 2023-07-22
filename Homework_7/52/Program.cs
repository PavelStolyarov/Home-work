// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void PrintArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 3} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int[,] massive, int min, int max)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void Sum(int[,] matr, int RowNumber, int col)
{
    int sum = 0;
    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < RowNumber; j++)
        {
            sum += matr[j, i];
        }
        Console.WriteLine($"sum of elements in {i + 1} column = {sum}");
        sum = 0;
    }
}
Console.WriteLine("Enter size, and bounds");
int rows = int.Parse(Console.ReadLine()!);
int columns = int.Parse(Console.ReadLine()!);
int MinValue = int.Parse(Console.ReadLine()!);
int MaxValue = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[rows, columns];
FillArray(matrix, MinValue, MaxValue);
PrintArray(matrix);
Sum(matrix, rows, columns);
