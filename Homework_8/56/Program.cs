// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array, int RowNumber, int col, int start, int end)
{
    for (int i = 0; i < RowNumber; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = start + new Random().Next(start, end);
        }
    }

}

void PrintArray(int[,] massive, int RowNumber, int col)
{
    for (int i = 0; i < RowNumber; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{massive[i, j],5}  ");
        }
        Console.WriteLine();
    }

}

void RowSums(int[,] matrix, int row, int col)
{
    int[] RowArr = new int[row];
    int rowSum = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            rowSum += matrix[i, j];
        }
        RowArr[i] = rowSum;
        rowSum = 0;
    }
    Console.WriteLine();
    SmallestSum(RowArr);
}

void SmallestSum(int[] ArrOfSums)
{
    int min = -10;
    for (int i = 0; i < ArrOfSums.Length - 1; i++)
    {
        if(ArrOfSums[i] < ArrOfSums[i + 1]) min = i + 1;
        else min = i + 2;
    }
    Console.WriteLine($"Smallest sum in {min} row");
}

Console.WriteLine("Enter size, and bounds");
int rows = int.Parse(Console.ReadLine()!);
int columns = int.Parse(Console.ReadLine()!);
int MinValue = int.Parse(Console.ReadLine()!);
int MaxValue = int.Parse(Console.ReadLine()!);
int[,] arr = new int[rows, columns];
FillArray(arr, rows, columns, MinValue, MaxValue);
PrintArray(arr, rows, columns);
RowSums(arr, rows, columns);