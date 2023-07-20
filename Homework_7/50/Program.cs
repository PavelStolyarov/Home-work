// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void FindElement(double[,] matrix, int RowNumber, int col)
{
    Console.WriteLine("Enter row and column index: ");
    int FindRow = int.Parse(Console.ReadLine()!);
    int FindColumn = int.Parse(Console.ReadLine()!);
    if(FindRow - 1 > RowNumber || FindColumn - 1 > col)
    {
        Console.WriteLine("There is no such element");
        return;
    }
    else Console.WriteLine($"{matrix[FindRow - 1, FindColumn - 1], 3} ");
}
Console.WriteLine("Enter size, and bounds");
int rows = int.Parse(Console.ReadLine()!);
int columns = int.Parse(Console.ReadLine()!);
double MinValue = double.Parse(Console.ReadLine()!);
double MaxValue = double.Parse(Console.ReadLine()!);
double[,] arr = new double[rows, columns];

FillArray(arr, rows, columns, MinValue, MaxValue);
PrintArray(arr, rows, columns);
FindElement(arr, rows, columns);