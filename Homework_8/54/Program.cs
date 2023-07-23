// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void SortNums(int[,] matrix, int row, int col)
{
    for (int n = 0; n < col; n++)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1]) (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);
            }
        }

    }

    Console.WriteLine();
    PrintArray(matrix, row, col);
}


Console.WriteLine("Enter size, and bounds");
int rows = int.Parse(Console.ReadLine()!);
int columns = int.Parse(Console.ReadLine()!);
int MinValue = int.Parse(Console.ReadLine()!);
int MaxValue = int.Parse(Console.ReadLine()!);
int[,] arr = new int[rows, columns];
FillArray(arr, rows, columns, MinValue, MaxValue);
PrintArray(arr, rows, columns);
SortNums(arr, rows, columns);