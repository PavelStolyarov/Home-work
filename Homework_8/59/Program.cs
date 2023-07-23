// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

int[] FindElement(int[,] massive, int RowNumber, int col)
{
    int element = 10000000;
    int row = -1;
    int column = -1;
    for (int i = 0; i < RowNumber; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (element > massive[i, j])
            {
                element = massive[i, j];
                row = i;
                column = j;
            }
        }
    }
    int[] array = new int[3];
    array[0] = element;
    array[1] = row;
    array[2] = column;
    return array;
}

void NewArray(int[,] matrix, int row, int col, int[] massive)
{
    int[,] NewMassive = new int[row - 1, col - 1];
    int k = 0, l = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (i != massive[1] && j != massive[2])
            {
                NewMassive[k, l] = matrix[i, j];
                l++;
            }


        }
        l = 0;
        if(massive[1] != i) k++;
    }
    PrintNewArray(NewMassive);
}

void PrintNewArray(int[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.Write($"{Arr[i, j],4}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter size, and bounds");
int rows = int.Parse(Console.ReadLine()!);
int columns = int.Parse(Console.ReadLine()!);
int MinValue = int.Parse(Console.ReadLine()!);
int MaxValue = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] arr = new int[rows, columns];
FillArray(arr, rows, columns, MinValue, MaxValue);
PrintArray(arr, rows, columns);
Console.WriteLine();
int[] elements = FindElement(arr, rows, columns);
Console.WriteLine();
NewArray(arr, rows, columns, elements);