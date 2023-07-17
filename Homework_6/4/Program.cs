// Напишите программу которая будет создавать копию заданного двумерного массива с помощью поэлементного копирования

void PrintArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = new Random().Next(1, 10);
        }
    }
}

void CopyArray(int[,] OldMatrix)
{
    int[,] NewMatrix = new int[4, 4];
    for (int i = 0; i < OldMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < NewMatrix.GetLength(1); j++)
        {
            NewMatrix[i, j] = OldMatrix[i, j];
        }
    }
    Console.WriteLine();
    PrintArray(NewMatrix);
}

int[,] matrix = new int[4, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
CopyArray(matrix);
