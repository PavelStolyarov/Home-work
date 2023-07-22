// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Данное решение я проверял для матриц со сторонами 2 и 2. Всё получилось.
// Но в некоторых других значениях выдаёт ошибку Index was outside the bounds of the array.(Допустим 3 и 4 для первой матрицы и 4 и 5 для второй). И я не понимаю как это исправить.
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
void SecFillArray(int[,] array, int RowNumber, int col, int start, int end)
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
void SecPrintArray(int[,] massive, int RowNumber, int col)
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
void PrintNewMatrix(int[,] finalArray)
{
    for (int i = 0; i < finalArray.GetLength(0); i++)
    {
        for (int j = 0; j < finalArray.GetLength(1); j++)
        {
            Console.Write($"{finalArray[i, j],5}  ");
        }
        Console.WriteLine();
    }
}

void CreateMewMatrix(int[,] matrix, int row, int col, int[,] secMatr, int Srow, int Scol)
{
    int[,] Matr = new int[row, Scol];
    if (col == Srow)
    {
        for (int i = 0; i < Scol; i++)
        {
            for (int j = 0; j < row; j++)
            {
                for (int n = 0; n < Scol; n++)
                {
                    Matr[i, j] += matrix[i, n] * secMatr[n, j];
                }
            }
        }
        Console.WriteLine();
        PrintNewMatrix(Matr);
    }
    else if (Scol == row)
    {
        for (int i = 0; i < col; i++)
        {
            for (int j = 0; j < Srow; j++)
            {
                for (int n = 0; n < col; n++)
                {
                    Matr[i, j] = secMatr[i, n] * matrix[n, j];
                }
            }
        }
        Console.WriteLine();
        PrintNewMatrix(Matr);
    }
    else
    {
        Console.WriteLine("Imposible");
        return;
    }
}
Console.WriteLine("Enter size, and bounds for first matrix: ");
int rows = int.Parse(Console.ReadLine()!);
int columns = int.Parse(Console.ReadLine()!);
int MinValue = int.Parse(Console.ReadLine()!);
int MaxValue = int.Parse(Console.ReadLine()!);
int[,] arr = new int[rows, columns];
Console.WriteLine("Enter size, and bounds for second matrix: ");
int SecRows = int.Parse(Console.ReadLine()!);
int SecColumns = int.Parse(Console.ReadLine()!);
int SecMinValue = int.Parse(Console.ReadLine()!);
int SecMaxValue = int.Parse(Console.ReadLine()!);
int[,] Mass = new int[SecRows, SecColumns];
int[,] newMatr = new int[rows, SecColumns];
FillArray(arr, rows, columns, MinValue, MaxValue);
SecFillArray(Mass, SecRows, SecColumns, SecMinValue, SecMaxValue);
PrintArray(arr, rows, columns);
Console.WriteLine();
SecPrintArray(Mass, SecRows, SecColumns);
CreateMewMatrix(arr, rows, columns, Mass, SecRows, SecColumns);
